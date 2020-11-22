
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Net.Sockets;
using Modbus.Device;

namespace SimpleHmi.PlcService
{
    public class ModPlcService : IPlcService
    {
        private TcpClient _client;
        private ModbusIpMaster _master;
        private readonly System.Timers.Timer _timer;
        private DateTime _lastScanTime;
        private volatile object _locker = new object();




        public ModPlcService()
        {

            _timer = new System.Timers.Timer();
            _timer.Interval = 10;
            _timer.Elapsed += OnTimerElapsed;
        }

        public ConnectionStates ConnectionState { get; private set; }

        public MachineState MachineState { get; private set; }


        public TimeSpan ScanTime { get; private set; }

        public int InletPumpSpeed { get; private set; }

        public int OutletPumpSpeed { get; private set; }

        public bool RoterMoveing { get; private set; }
        public int ReadRoterJogSpeed { get; private set; }
        public int ReadRoterPosSpeed { get; private set; }
        public int ReadRoterCmdPos { get; private set; }

        public bool RoteryPosMoveing { get; private set; }
        public int ReadRoteryPosJogSpeed { get; private set; }
        public int ReadRoteryPosPosSpeed { get; private set; }
        public int ReadRoteryPosCmdPos { get; private set; }


        public bool ShorterMoveing { get; private set; }
        public int ReadShorterJogSpeed { get; private set; }
        public int ReadShorterPosSpeed { get; private set; }
        public int ReadShorterCmdPos { get; private set; }

        public bool MainGripperState { get; private set; }
        public bool ShorterGripperState { get; private set; }
        public bool ShorterCylinderState { get; private set; }

        public int ProductselectedCount { get; private set; }
        public int TotalPartCount { get; private set; }
        public int GoodPartCount { get; private set; }
        public int NotGoodPartCount { get; private set; }


        public bool AligmentCheck { get; private set; }

        public bool CrackCheck { get; private set; }

        public bool DustCheck { get; private set; }

        public bool TestResultState { get; private set; }

        public bool  VisiontestComplete { get; private set; }



        public event EventHandler ValuesRefreshed;

        public void Connect(string ipAddress, int rack, int slot)
        {
            try
            {
                ConnectionState = ConnectionStates.Connecting;
                _client = new TcpClient(ipAddress, 502);
                _master = ModbusIpMaster.CreateIp(_client);
                ConnectionState = ConnectionStates.Online;
                int result = Convert.ToInt32(_client.Connected);
                if (result == 1)
                {
                    ConnectionState = ConnectionStates.Online;
                    _timer.Start();
                }
                else
                {
                    Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "\t Connection error: ");
                    ConnectionState = ConnectionStates.Offline;
                }
                OnValuesRefreshed();
            }
            catch
            {
                ConnectionState = ConnectionStates.Offline;
                OnValuesRefreshed();

                throw;
            }
        }

        public void Disconnect()
        {
            if (_client.Connected)
            {
                _timer.Stop();
                _master.Dispose();
                _client.Close();
                ConnectionState = ConnectionStates.Offline;
                OnValuesRefreshed();
            }
        }
        public async Task WriteStart()
        {
            await Task.Run(() =>
            {                
                _master.WriteSingleCoilAsync(16, 0, true);
                MachineState = MachineState.Auto;
                Thread.Sleep(30);


            });
        }
        public async Task WriteStop()
        {
            await Task.Run(() =>
            {
          
                _master.WriteSingleCoilAsync(16, 0, false);
                MachineState = MachineState.Manual;
                Thread.Sleep(30);

            });
        }
        public Task WriteSpeedInletPump(ushort speed)
        {
            return Task.Run(() => {
                _master.WriteSingleRegister(1, 5, speed);

            });

        }

        public Task WriteSpeedOutletPump(ushort speed)
        {
            return Task.Run(() => {
                _master.WriteSingleRegister(1, 6, speed);

            });
        }



        public Task WriteSpeedInletPump(short speed)
        {
            return Task.Run(() => {
                ushort Speed = Convert.ToUInt16(speed);
                _master.WriteSingleRegisterAsync(1, Speed);
            });
        }

        public Task WriteSpeedOutletPump(short speed)
        {
            return Task.Run(() => {
                ushort Speed = Convert.ToUInt16(speed);
                _master.WriteSingleRegisterAsync(2, Speed);
            });
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                _timer.Stop();
                ScanTime = DateTime.Now - _lastScanTime;
                RefreshValues();
                OnValuesRefreshed();
            }
            finally
            {
                _timer.Start();
            }
            _lastScanTime = DateTime.Now;
        }

        private void RefreshValues()
        {
            lock (_locker)
            {
                {
                    if (_master != null)
                    {
                        bool[] readCoils = _master.ReadCoils(1, 0, 50);

                        RoterMoveing = readCoils[17];
                        RoteryPosMoveing = readCoils[19];
                        ShorterMoveing = readCoils[19];
                                                
                        ShorterGripperState = readCoils[12];
                        ShorterCylinderState = readCoils[13];
                        MainGripperState = readCoils[14];


                        AligmentCheck = readCoils[27];
                        CrackCheck = readCoils[28];
                        DustCheck = readCoils[29];
                        TestResultState = readCoils[30];
                        VisiontestComplete = readCoils[31];



                        ushort[] readHoldingRegister = _master.ReadHoldingRegisters(1, 0, 50);
                        
                        InletPumpSpeed = Convert.ToInt32(readHoldingRegister[40]);
                        OutletPumpSpeed = Convert.ToInt32(readHoldingRegister[41]);

                        ReadRoterJogSpeed = Convert.ToInt32(readHoldingRegister[1]);
                        ReadRoterPosSpeed = Convert.ToInt32(readHoldingRegister[2]);
                        ReadRoterCmdPos = Convert.ToInt32(readHoldingRegister[3]);

                        ReadRoteryPosJogSpeed = Convert.ToInt32(readHoldingRegister[7]);
                        ReadRoteryPosPosSpeed = Convert.ToInt32(readHoldingRegister[6]);
                        ReadRoteryPosCmdPos = Convert.ToInt32(readHoldingRegister[5]);

                        ReadShorterJogSpeed = Convert.ToInt32(readHoldingRegister[12]);
                        ReadShorterPosSpeed = Convert.ToInt32(readHoldingRegister[13]);
                        ReadShorterCmdPos = Convert.ToInt32(readHoldingRegister[14]);

                        ProductselectedCount = Convert.ToInt32(readHoldingRegister[28]);
                        TotalPartCount = Convert.ToInt32(readHoldingRegister[29]);
                        GoodPartCount = Convert.ToInt32(readHoldingRegister[30]);
                        NotGoodPartCount = Convert.ToInt32(readHoldingRegister[31]);



                    }
                }

            }
        }




        private void OnValuesRefreshed()
        {
            ValuesRefreshed?.Invoke(this, new EventArgs());
        }

        public async Task WriteRoterJogPositveStart()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(30);
                _master.WriteSingleCoilAsync(1, 1, true);

            });
        }

        public async Task WriteRoterJogPositveStop()
        {
            await Task.Run(() =>
            {
               
                _master.WriteSingleCoilAsync(1, 2, false);

            });
        }

        public async Task WriteRoterJogNegativeStart()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(10);
                _master.WriteSingleCoilAsync(1, 2, true);

            });
        }

        public async Task WriteRoterJogNegativeStop()
        {
            await Task.Run(() =>
            {
                
                _master.WriteSingleCoilAsync(1, 2, false);

            });
        }

        public async Task WriteRoterPostionStartCommand()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(10);
                _master.WriteSingleCoilAsync(1, 3, true);
                Thread.Sleep(150);
                _master.WriteSingleCoilAsync(1, 3, false);

            });
        }

        public Task WriteRoterJogSpeed(short RoterJogSpeed)
        {
            return Task.Run(() => {
                ushort Speed = Convert.ToUInt16(RoterJogSpeed);
                _master.WriteSingleRegisterAsync(1, Speed);
            });
        }

        public Task WriteRoterPositioningSpeed(short RoterPositioningSpeed)
        {
            return Task.Run(() => {
                ushort Speed = Convert.ToUInt16(RoterPositioningSpeed);
                _master.WriteSingleRegisterAsync(2, Speed);
            });
        }

        public Task WriteRoterCommendposition(short RoterCommendposition)
        {
            return Task.Run(() => {
                ushort Position = Convert.ToUInt16(RoterCommendposition);
                _master.WriteSingleRegisterAsync(3, Position);
            });
        }

        public async Task WriteRoteryPosJogPositveStart()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(10);
                _master.WriteSingleCoilAsync(1, 5, true);

            });
        }

        public async Task WriteRoteryPosJogPositveStop()
        {
            await Task.Run(() =>
            {
                
                _master.WriteSingleCoilAsync(1, 5, false);

            });
        }

        public async Task WriteRoteryPosJogNegativeStart()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(10);
                _master.WriteSingleCoilAsync(1, 6, true);

            });
        }

        public async Task WriteRoteryPosJogNegativeStop()
        {
            await Task.Run(() =>
            {
                
                _master.WriteSingleCoilAsync(1, 6, false);

            });
        }

        public async Task WriteRoteryPosPostionStartCommand()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(10);
                _master.WriteSingleCoilAsync(1, 7, true);
                Thread.Sleep(150);
                _master.WriteSingleCoilAsync(1, 7, false);

            });
        }

        public Task WriteRoteryPosJogSpeed(short RoteryPosJogSpeed)
        {
            return Task.Run(() => {
                ushort Speed = Convert.ToUInt16(RoteryPosJogSpeed);
                _master.WriteSingleRegisterAsync(7, Speed);
            });
        }

        public Task WriteRoteryPosPositioningSpeed(short RoteryPosPositioningSpeed)
        {
            return Task.Run(() => {
                ushort Speed = Convert.ToUInt16(RoteryPosPositioningSpeed);
                _master.WriteSingleRegisterAsync(6, Speed);
            });
        }

        public Task WriteRoteryPosCommendposition(short RoteryPosCommendposition)
        {
            return Task.Run(() => {
                ushort Position = Convert.ToUInt16(RoteryPosCommendposition);
                _master.WriteSingleRegisterAsync(5, Position);
            });
        }


        public async Task WriteShorterJogPositveStart()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(10);
                _master.WriteSingleCoilAsync(1, 9, true);

            });
        }

        public async Task WriteShorterJogPositveStop()
        {
            await Task.Run(() =>
            {
                
                _master.WriteSingleCoilAsync(1, 9, false);

            });
        }

        public async Task WriteShorterJogNegativeStart()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(10);
                _master.WriteSingleCoilAsync(1, 10, true);

            });
        }

        public async Task WriteShorterJogNegativeStop()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(30);
                _master.WriteSingleCoilAsync(1, 10, false);

            });
        }

        public async Task WriteShorterPostionStartCommand()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(30);
                _master.WriteSingleCoilAsync(1, 11, true);
                Thread.Sleep(150);
                _master.WriteSingleCoilAsync(1, 11, false);

            });
        }

        public Task WriteShorterJogSpeed(short ShorterJogSpeed)
        {
            return Task.Run(() => {
                ushort Speed = Convert.ToUInt16(ShorterJogSpeed);
                _master.WriteSingleRegisterAsync(12, Speed);
            });
        }

        public Task WriteShorterPositioningSpeed(short ShorterPositioningSpeed)
        {
            return Task.Run(() => {
                ushort Speed = Convert.ToUInt16(ShorterPositioningSpeed);
                _master.WriteSingleRegisterAsync(13, Speed);
            });
        }

        public Task WriteShorterCommendposition(short ShorterCommendposition)
        {
            return Task.Run(() => {
                ushort Position = Convert.ToUInt16(ShorterCommendposition);
                _master.WriteSingleRegisterAsync(14, Position);
            });
        }

    


        public async Task WriteShorterGripperStartCommand()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(30);
                _master.WriteSingleCoilAsync(1, 12, true);

            });
        }

        public async Task WriteShorterGripperStopCommand()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(30);
                _master.WriteSingleCoilAsync(1, 12, false);

            });
        }


        public async Task WriteShorterCylinderStartCommand()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(30);
                _master.WriteSingleCoilAsync(1, 13, true);

            });
        }

        public async Task WriteShorterCylinderStopCommandT()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(30);
                _master.WriteSingleCoilAsync(1, 13, false);

            });
        }
        public async Task WriteMainGripperStartCommand()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(30);
                _master.WriteSingleCoilAsync(1, 14, true);

            });
        }

        public async Task WriteMainGripperStopCommand()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(30);
                _master.WriteSingleCoilAsync(1, 14, false);

            });
        }

        public async Task WriteShorterPostionHomingCommand()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(10);
                _master.WriteSingleCoilAsync(1, 8, true);
                Thread.Sleep(150);
                _master.WriteSingleCoilAsync(1, 8, false);

            });
        }

        public async Task WriteRoteryPosPostionHomingCommand()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(10);
                _master.WriteSingleCoilAsync(1, 4, true);
                Thread.Sleep(150);
                _master.WriteSingleCoilAsync(1, 4, false);

            });
        }

        public async Task WriteRoterPostionHomingCommand()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(10);
                _master.WriteSingleCoilAsync(1, 0, true);
                Thread.Sleep(150);
                _master.WriteSingleCoilAsync(1, 0, false);

            });
        }


        public async Task WriteErrorResetCommand()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(30);
                _master.WriteSingleCoilAsync(1, 15, true);
                Thread.Sleep(100);
                _master.WriteSingleCoilAsync(1, 15, false);

            });
        }

        public async Task WriteProductionResetCommand()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(30);
                _master.WriteSingleCoilAsync(1, 15, true);
                Thread.Sleep(100);
                _master.WriteSingleCoilAsync(1, 15, false);

            });
        }
        public async Task WriteInitializationCommand()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(30);
                _master.WriteSingleCoilAsync(1, 23, true);
                Thread.Sleep(100);
                _master.WriteSingleCoilAsync(1, 23, false);

            });
        }

        public async Task WriteAlignmentTestCommand()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(10);
                _master.WriteSingleCoilAsync(1, 24, true);
                Thread.Sleep(150);
                _master.WriteSingleCoilAsync(1, 24, false);

            });
        }


        public async Task WriteCrackCheckCommand()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(10);
                _master.WriteSingleCoilAsync(1, 25, true);
                Thread.Sleep(150);
                _master.WriteSingleCoilAsync(1, 25, false);

            });
        }

        public async Task WriteDustCheckCommand()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(10);
                _master.WriteSingleCoilAsync(1, 26, true);
                Thread.Sleep(150);
                _master.WriteSingleCoilAsync(1, 26, false);

            });
        }


        public async Task AligmentCheckSelected()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(30);
                _master.WriteSingleCoilAsync(1, 27, true);

            });
        }

        public async Task AligmentCheckNotSelected()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(30);
                _master.WriteSingleCoilAsync(1, 27, false);

            });
        }

        public async Task CrackCheckSelected()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(30);
                _master.WriteSingleCoilAsync(1,28, true);

            });
        }

        public async Task CrackCheckNotSelected()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(30);
                _master.WriteSingleCoilAsync(1, 28, false);

            });
        }

        public async Task DustCheckSelected()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(30);
                _master.WriteSingleCoilAsync(1, 29, true);

            });
        }

        public async Task DustCheckNotSelected()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(30);
                _master.WriteSingleCoilAsync(1, 29, false);

            });
        }



    }
}


