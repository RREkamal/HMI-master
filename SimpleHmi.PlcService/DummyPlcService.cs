using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleHmi.PlcService
{
    public class DummyPlcService : IPlcService
    {
        public ConnectionStates ConnectionState { get; private set; }

        public bool HighLimit { get; private set; }

        public int InletPumpSpeed { get; private set; }

        public bool LowLimit { get; private set; }

        public int OutletPumpSpeed { get; private set; }

        public bool PumpState { get; private set; }

        public TimeSpan ScanTime { get; private set; }

        public int TankLevel { get; private set; }

        public bool CylinderState => throw new NotImplementedException();

        public bool Gripper1State => throw new NotImplementedException();

        public bool Gripper2State => throw new NotImplementedException();

        public bool DustcaseResultState => throw new NotImplementedException();

        public bool CarckcaseResultState => throw new NotImplementedException();

        public bool AligmentcaseResultState => throw new NotImplementedException();

        public bool Shorter1MoveingState => throw new NotImplementedException();

        public bool Shorter2MoveingState => throw new NotImplementedException();

        public bool RoterMoveingState => throw new NotImplementedException();

        public bool InitilizationState => throw new NotImplementedException();

        public int ReadShorter1JogSpeed => throw new NotImplementedException();

        public int ReadShorter2JogSpeed => throw new NotImplementedException();

        public int ReadRoterJogSpeed => throw new NotImplementedException();

        public int ReadShorter1PosSpeed => throw new NotImplementedException();

        public int ReadShorter2PosSpeed => throw new NotImplementedException();

        public int ReadRoterPosSpeed => throw new NotImplementedException();

        public int ReadShorter1Position => throw new NotImplementedException();

        public int ReadShorter2Position => throw new NotImplementedException();

        public int ReadRoterPosition => throw new NotImplementedException();

        public int TotalDustcaseGoodCount => throw new NotImplementedException();

        public int TotalDustcaseBadCount => throw new NotImplementedException();

        public int TotalCrackcaseGoodCount => throw new NotImplementedException();

        public int TotalCrackcaseBadCount => throw new NotImplementedException();

        public int TotalALigmentcaseGoodCount => throw new NotImplementedException();

        public int TotalALigmentcaseBadCount => throw new NotImplementedException();

        public int TotalGoodCount => throw new NotImplementedException();

        public int TotalbadCount => throw new NotImplementedException();

        public bool RoterMoveing => throw new NotImplementedException();

        public int ReadRoterCmdPos => throw new NotImplementedException();

        public bool RoteryPosMoveing => throw new NotImplementedException();

        public int ReadRoteryPosJogSpeed => throw new NotImplementedException();

        public int ReadRoteryPosPosSpeed => throw new NotImplementedException();

        public int ReadRoteryPosCmdPos => throw new NotImplementedException();

        public bool ShorterMoveing => throw new NotImplementedException();

        public int ReadShorterJogSpeed => throw new NotImplementedException();

        public int ReadShorterPosSpeed => throw new NotImplementedException();

        public int ReadShorterCmdPos => throw new NotImplementedException();

        public bool MainGripperState => throw new NotImplementedException();

        public bool ShorterGripperState => throw new NotImplementedException();

        public bool ShorterCylinderState => throw new NotImplementedException();

        public int ProductselectedCount => throw new NotImplementedException();

        public int TotalPartCount => throw new NotImplementedException();

        public int GoodPartCount => throw new NotImplementedException();

        public int NotGoodPartCount => throw new NotImplementedException();

        public bool AligmentCheck => throw new NotImplementedException();

        public bool CrackCheck => throw new NotImplementedException();

        public bool DustCheck => throw new NotImplementedException();

        public MachineState MachineState => throw new NotImplementedException();

        public bool TestResultState => throw new NotImplementedException();

        public bool VisiontestComplete => throw new NotImplementedException();

        public event EventHandler ValuesRefreshed;

        private System.Timers.Timer _timer;
        private DateTime _lastScanTime;

        public DummyPlcService()
        {
            _timer = new System.Timers.Timer();
            _timer.Elapsed += OnTimerElapsed;
            _timer.Interval = 100;
            InletPumpSpeed = 3;
            OutletPumpSpeed = 2;
        }

        private void OnTimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            _timer.Stop();


            TankLevel -= OutletPumpSpeed;
            TankLevel = Math.Max(TankLevel, 0);


            if (PumpState)
            {
                TankLevel += InletPumpSpeed;
                TankLevel = Math.Min(TankLevel, 100);
            }
            LowLimit = TankLevel < 10;
            HighLimit = TankLevel > 90;
            ScanTime = DateTime.Now - _lastScanTime;
            OnValuesRefreshed();
            _timer.Start();
            _lastScanTime = DateTime.Now;
        }

        public void Connect(string ipAddress, int rack, int slot)
        {
            ConnectionState = ConnectionStates.Connecting;
            OnValuesRefreshed();
            ConnectionState = ConnectionStates.Online;
            _timer.Start();
        }

        public void Disconnect()
        {
            ConnectionState = ConnectionStates.Offline;
            OnValuesRefreshed();
            _timer.Stop();
        }

        public Task WriteSpeedInletPump(short speed)
        {
            return Task.Run(() => { InletPumpSpeed = speed; });
        }

        public Task WriteSpeedOutletPump(short speed)
        {
            return Task.Run(() => { OutletPumpSpeed = speed; });
        }

        public Task WriteStart()
        {
            return Task.Run(() => {
                PumpState = true;
            });
        }

        public Task WriteStop()
        {
            return Task.Run(() => {
                PumpState = false;
            });
        }

        private void OnValuesRefreshed()
        {
            ValuesRefreshed?.Invoke(this, new EventArgs());
        }

        public Task InitilizationStart()
        {
            throw new NotImplementedException();
        }

        public Task ErrorReset()
        {
            throw new NotImplementedException();
        }

        public Task WriteShorter1JogSpeed(short Shorter1JogSpeed)
        {
            throw new NotImplementedException();
        }

        public Task WriteShorter2JogSpeed(short Shorter2JogSpeed)
        {
            throw new NotImplementedException();
        }

        public Task WriteRoterJogSpeed(short RoterJogSpeed)
        {
            throw new NotImplementedException();
        }

        public Task WriteShorter1PosSpeed(short Shorter1PosSpeed)
        {
            throw new NotImplementedException();
        }

        public Task WriteShorter2PosSpeed(short Shorter2PosSpeed)
        {
            throw new NotImplementedException();
        }

        public Task WriteRoterPosSpeed(short RoterPosSpeed)
        {
            throw new NotImplementedException();
        }

        public Task WriteShorter1Position(short Shorter1Position)
        {
            throw new NotImplementedException();
        }

        public Task WriteShorter2Position(short Shorter2Position)
        {
            throw new NotImplementedException();
        }

        public Task WriteRoterPosition(short RoterPosition)
        {
            throw new NotImplementedException();
        }

        public Task Cylinderup()
        {
            throw new NotImplementedException();
        }

        public Task CylinderDown()
        {
            throw new NotImplementedException();
        }

        public Task Gripper1close()
        {
            throw new NotImplementedException();
        }

        public Task Gripper1open()
        {
            throw new NotImplementedException();
        }

        public Task Gripper2close()
        {
            throw new NotImplementedException();
        }

        public Task Gripper2open()
        {
            throw new NotImplementedException();
        }

        public Task DustTest_Run()
        {
            throw new NotImplementedException();
        }

        public Task DustTest_Stop()
        {
            throw new NotImplementedException();
        }

        public Task CrackTest_Run()
        {
            throw new NotImplementedException();
        }

        public Task CrackTest_Stop()
        {
            throw new NotImplementedException();
        }

        public Task AligmentTest_Run()
        {
            throw new NotImplementedException();
        }

        public Task AligmentTest_Stop()
        {
            throw new NotImplementedException();
        }

        public Task Shorter1JogStart()
        {
            throw new NotImplementedException();
        }

        public Task Shorter1JogStop()
        {
            throw new NotImplementedException();
        }

        public Task Shorter2JogStart()
        {
            throw new NotImplementedException();
        }

        public Task Shorter2JogStop()
        {
            throw new NotImplementedException();
        }

        public Task RoterJogStart()
        {
            throw new NotImplementedException();
        }

        public Task RoterJogStop()
        {
            throw new NotImplementedException();
        }

        public Task Shorter1PosStart()
        {
            throw new NotImplementedException();
        }

        public Task Shorter1PosStop()
        {
            throw new NotImplementedException();
        }

        public Task Shorter2PosStart()
        {
            throw new NotImplementedException();
        }

        public Task Shorter2PosStop()
        {
            throw new NotImplementedException();
        }

        public Task RoterPosStart()
        {
            throw new NotImplementedException();
        }

        public Task RoterPosStop()
        {
            throw new NotImplementedException();
        }

        public Task ProductionCountResetStart()
        {
            throw new NotImplementedException();
        }

        public Task ProductionCountResetStop()
        {
            throw new NotImplementedException();
        }

        public Task Shorter1JogPositiveStart()
        {
            throw new NotImplementedException();
        }

        public Task Shorter1JogPositiveStop()
        {
            throw new NotImplementedException();
        }

        public Task Shorter2JogPositiveStart()
        {
            throw new NotImplementedException();
        }

        public Task Shorter2JogPositiveStop()
        {
            throw new NotImplementedException();
        }

        public Task RoterJogPositiveStart()
        {
            throw new NotImplementedException();
        }

        public Task RoterJogPositiveStop()
        {
            throw new NotImplementedException();
        }

        public Task Shorter1JogNegativeStart()
        {
            throw new NotImplementedException();
        }

        public Task Shorter1JogNegativeStop()
        {
            throw new NotImplementedException();
        }

        public Task Shorter2JogNegativeStart()
        {
            throw new NotImplementedException();
        }

        public Task Shorter2JogNegativeStop()
        {
            throw new NotImplementedException();
        }

        public Task RoterJogPositveStart()
        {
            throw new NotImplementedException();
        }

        public Task RoterJogPositveStop()
        {
            throw new NotImplementedException();
        }

        public Task RoterJogNegativeStart()
        {
            throw new NotImplementedException();
        }

        public Task RoterJogNegativeStop()
        {
            throw new NotImplementedException();
        }

        public Task WriteRoterJogPositveStart()
        {
            throw new NotImplementedException();
        }

        public Task WriteRoterJogPositveStop()
        {
            throw new NotImplementedException();
        }

        public Task WriteRoterJogNegativeStart()
        {
            throw new NotImplementedException();
        }

        public Task WriteRoterJogNegativeStop()
        {
            throw new NotImplementedException();
        }

        public Task WriteRoterPostionStartCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteRoterPositioningSpeed(short RoterPositioningSpeed)
        {
            throw new NotImplementedException();
        }

        public Task WriteRoterCommendposition(short RoterCommendposition)
        {
            throw new NotImplementedException();
        }

        public Task WriteRoteryPosJogPositveStart()
        {
            throw new NotImplementedException();
        }

        public Task WriteRoteryPosJogPositveStop()
        {
            throw new NotImplementedException();
        }

        public Task WriteRoteryPosJogNegativeStart()
        {
            throw new NotImplementedException();
        }

        public Task WriteRoteryPosJogNegativeStop()
        {
            throw new NotImplementedException();
        }

        public Task WriteRoteryPosPostionStartCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteRoteryPosJogSpeed(short RoteryPosJogSpeed)
        {
            throw new NotImplementedException();
        }

        public Task WriteRoteryPosPositioningSpeed(short RoteryPosPositioningSpeed)
        {
            throw new NotImplementedException();
        }

        public Task WriteRoteryPosCommendposition(short RoteryPosCommendposition)
        {
            throw new NotImplementedException();
        }

        public Task WriteShorterJogPositveStart()
        {
            throw new NotImplementedException();
        }

        public Task WriteShorterJogPositveStop()
        {
            throw new NotImplementedException();
        }

        public Task WriteShorterJogNegativeStart()
        {
            throw new NotImplementedException();
        }

        public Task WriteShorterJogNegativeStop()
        {
            throw new NotImplementedException();
        }

        public Task WriteShorterPostionStartCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteShorterJogSpeed(short ShorterJogSpeed)
        {
            throw new NotImplementedException();
        }

        public Task WriteShorterPositioningSpeed(short ShorterPositioningSpeed)
        {
            throw new NotImplementedException();
        }

        public Task WriteShorterCommendposition(short ShorterCommendposition)
        {
            throw new NotImplementedException();
        }

        public Task WriteMainGripperStartCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteMainGripperStopCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteShorterGripperStartCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteShorterGripperStopCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteShorterCylinderStartCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteShorterCylinderStopCommandT()
        {
            throw new NotImplementedException();
        }

        public Task WriteShorterPostionHomingCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteRoteryPosPostionHomingCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteRoterPostionHomingCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteInitializationCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteErrorResetCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteProductionResetCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteAlignmentTestCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteCrackCheckCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteDustCheckCommand()
        {
            throw new NotImplementedException();
        }

        public Task AligmentCheckSelected()
        {
            throw new NotImplementedException();
        }

        public Task AligmentCheckNotSelected()
        {
            throw new NotImplementedException();
        }

        public Task CrackCheckSelected()
        {
            throw new NotImplementedException();
        }

        public Task CrackCheckNotSelected()
        {
            throw new NotImplementedException();
        }

        public Task DustCheckSelected()
        {
            throw new NotImplementedException();
        }

        public Task DustCheckNotSelected()
        {
            throw new NotImplementedException();
        }
    }
}
