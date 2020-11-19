using SimpleHmi.PlcService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHmi.Designer
{
    class DesignPlcService : IPlcService
    {
        public ConnectionStates ConnectionState
        {
            get
            {
                return ConnectionStates.Online;
            }
        }

        public bool HighLimit
        {
            get { return false; }
        }

        public int InletPumpSpeed
        {
            get { return 1; }
        }

        public bool LowLimit
        {
            get { return true; }
        }

        public int OutletPumpSpeed
        {
            get { return 2; }
        }

        public bool PumpState
        {
            get { return true; }
        }

        public TimeSpan ScanTime
        {
            get
            {
                return TimeSpan.FromMilliseconds(2550);
            }
        }

        public int TankLevel
        {
            get { return 21; }
        }

        public bool CylinderState
        {
            get { return true; }
        }


        public bool Gripper1State
        {
            get { return true; }
        }

        public bool Gripper2State
        {
            get { return true; }
        }

        public bool DustcaseResultState
        {
            get { return true; }
        }

        public bool CarckcaseResultState
        {
            get { return true; }
        }

        public bool AligmentcaseResultState
        {
            get { return true; }
        }

        public bool Shorter1MoveingState
        {
            get { return true; }
        }

        public bool Shorter2MoveingState
        {
            get { return true; }
        }

        public bool RoterMoveingState
        {
            get { return true; }
        }

        public bool InitilizationState
        {
            get { return true; }
        }

        public int ReadShorter1JogSpeed
        {
            get { return 2; }
        }

        public int ReadShorter2JogSpeed
        {
            get { return 2; }
        }

        public int ReadRoterJogSpeed
        {
            get { return 2; }
        }

        public int ReadShorter1PosSpeed
        {
            get { return 2; }
        }

        public int ReadShorter2PosSpeed
        {
            get { return 2; }
        }

        public int ReadRoterPosSpeed
        {
            get { return 2; }
        }

        public int ReadShorter1Position
        {
            get { return 2; }
        }

        public int ReadShorter2Position
        {
            get { return 2; }
        }

        public int ReadRoterPosition
        {
            get { return 2; }
        }

        public int TotalDustcaseGoodCount
        {
            get { return 2; }
        }

        public int TotalDustcaseBadCount
        {
            get { return 2; }
        }

        public int TotalCrackcaseGoodCount
        {
            get { return 2; }
        }

        public int TotalCrackcaseBadCount
        {
            get { return 2; }
        }

        public int TotalALigmentcaseGoodCount
        {
            get { return 2; }
        }

        public int TotalALigmentcaseBadCount
        {
            get { return 2; }
        }

        public int TotalGoodCount
        {
            get { return 2; }
        }

        public int TotalbadCount
        {
            get { return 2; }
        }

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

        public event EventHandler ValuesRefreshed { add { } remove { } } // avoid warning CS0067

        public Task AligmentCheckNotSelected()
        {
            throw new NotImplementedException();
        }

        public Task AligmentCheckSelected()
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

        public void Connect(string ipAddress, int rack, int slot)
        {
            throw new NotImplementedException();
        }

        public Task CrackCheckNotSelected()
        {
            throw new NotImplementedException();
        }

        public Task CrackCheckSelected()
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

        public Task CylinderDown()
        {
            throw new NotImplementedException();
        }

        public Task Cylinderup()
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public Task DustCheckNotSelected()
        {
            throw new NotImplementedException();
        }

        public Task DustCheckSelected()
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

        public Task ErrorReset()
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

        public Task InitilizationStart()
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

        public Task RoterJogNegativeStart()
        {
            throw new NotImplementedException();
        }

        public Task RoterJogNegativeStop()
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

        public Task RoterJogPositveStart()
        {
            throw new NotImplementedException();
        }

        public Task RoterJogPositveStop()
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

        public Task RoterPosStart()
        {
            throw new NotImplementedException();
        }

        public Task RoterPosStop()
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

        public Task Shorter1JogPositiveStart()
        {
            throw new NotImplementedException();
        }

        public Task Shorter1JogPositiveStop()
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

        public Task Shorter1PosStart()
        {
            throw new NotImplementedException();
        }

        public Task Shorter1PosStop()
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

        public Task Shorter2JogPositiveStart()
        {
            throw new NotImplementedException();
        }

        public Task Shorter2JogPositiveStop()
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

        public Task Shorter2PosStart()
        {
            throw new NotImplementedException();
        }

        public Task Shorter2PosStop()
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

        public Task WriteErrorResetCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteInitializationCommand()
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

        public Task WriteProductionResetCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteRoterCommendposition(short RoterCommendposition)
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

        public Task WriteRoterJogPositveStart()
        {
            throw new NotImplementedException();
        }

        public Task WriteRoterJogPositveStop()
        {
            throw new NotImplementedException();
        }

        public Task WriteRoterJogSpeed(short RoterJogSpeed)
        {
            throw new NotImplementedException();
        }

        public Task WriteRoterPosition(short RoterPosition)
        {
            throw new NotImplementedException();
        }

        public Task WriteRoterPositioningSpeed(short RoterPositioningSpeed)
        {
            throw new NotImplementedException();
        }

        public Task WriteRoterPosSpeed(short RoterPosSpeed)
        {
            throw new NotImplementedException();
        }

        public Task WriteRoterPostionHomingCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteRoterPostionStartCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteRoteryPosCommendposition(short RoteryPosCommendposition)
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

        public Task WriteRoteryPosJogPositveStart()
        {
            throw new NotImplementedException();
        }

        public Task WriteRoteryPosJogPositveStop()
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

        public Task WriteRoteryPosPostionHomingCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteRoteryPosPostionStartCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteShorter1JogSpeed(short Shorter1JogSpeed)
        {
            throw new NotImplementedException();
        }

        public Task WriteShorter1Position(short Shorter1Position)
        {
            throw new NotImplementedException();
        }

        public Task WriteShorter1PosSpeed(short Shorter1PosSpeed)
        {
            throw new NotImplementedException();
        }

        public Task WriteShorter2JogSpeed(short Shorter2JogSpeed)
        {
            throw new NotImplementedException();
        }

        public Task WriteShorter2Position(short Shorter2Position)
        {
            throw new NotImplementedException();
        }

        public Task WriteShorter2PosSpeed(short Shorter2PosSpeed)
        {
            throw new NotImplementedException();
        }

        public Task WriteShorterCommendposition(short ShorterCommendposition)
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

        public Task WriteShorterGripperStartCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteShorterGripperStopCommand()
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

        public Task WriteShorterJogPositveStart()
        {
            throw new NotImplementedException();
        }

        public Task WriteShorterJogPositveStop()
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

        public Task WriteShorterPostionHomingCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteShorterPostionStartCommand()
        {
            throw new NotImplementedException();
        }

        public Task WriteSpeedInletPump(short speed)
        {
            throw new NotImplementedException();
        }

        public Task WriteSpeedOutletPump(short speed)
        {
            throw new NotImplementedException();
        }

        public Task WriteStart()
        {
            throw new NotImplementedException();
        }

        public Task WriteStop()
        {
            throw new NotImplementedException();
        }
    }
}
