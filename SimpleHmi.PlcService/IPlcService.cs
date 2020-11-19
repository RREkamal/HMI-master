using System;
using System.Threading.Tasks;

namespace SimpleHmi.PlcService
{
    public interface IPlcService
    {
        ConnectionStates ConnectionState { get; }
       
        int InletPumpSpeed { get; }
        
        int OutletPumpSpeed { get; }
        
        TimeSpan ScanTime { get; }      
        MachineState MachineState { get; }
        event EventHandler ValuesRefreshed;
        void Connect(string ipAddress, int rack, int slot);
        void Disconnect();
        Task WriteSpeedInletPump(short speed);
        Task WriteSpeedOutletPump(short speed);
        Task WriteStart();
        Task WriteStop();
        //latest roter//
        Task WriteRoterJogPositveStart();
        Task WriteRoterJogPositveStop();
        Task WriteRoterJogNegativeStart();
        Task WriteRoterJogNegativeStop();
        Task WriteRoterPostionStartCommand();
        Task WriteRoterJogSpeed(short RoterJogSpeed);
        Task WriteRoterPositioningSpeed(short RoterPositioningSpeed);
        Task WriteRoterCommendposition(short RoterCommendposition);
        bool RoterMoveing { get; }
        int ReadRoterJogSpeed { get; }
        int ReadRoterPosSpeed { get; }
        int ReadRoterCmdPos { get; }

        //latest RoteryPos//
        Task WriteRoteryPosJogPositveStart();
        Task WriteRoteryPosJogPositveStop();
        Task WriteRoteryPosJogNegativeStart();
        Task WriteRoteryPosJogNegativeStop();
        Task WriteRoteryPosPostionStartCommand();
        Task WriteRoteryPosJogSpeed(short RoteryPosJogSpeed);
        Task WriteRoteryPosPositioningSpeed(short RoteryPosPositioningSpeed);
        Task WriteRoteryPosCommendposition(short RoteryPosCommendposition);
        bool RoteryPosMoveing { get; }
        int ReadRoteryPosJogSpeed { get; }
        int ReadRoteryPosPosSpeed { get; }
        int ReadRoteryPosCmdPos { get; }

        //latest Shorter2//
        Task WriteShorterJogPositveStart();
        Task WriteShorterJogPositveStop();
        Task WriteShorterJogNegativeStart();
        Task WriteShorterJogNegativeStop();
        Task WriteShorterPostionStartCommand();
        Task WriteShorterJogSpeed(short ShorterJogSpeed);
        Task WriteShorterPositioningSpeed(short ShorterPositioningSpeed);
        Task WriteShorterCommendposition(short ShorterCommendposition);
        bool ShorterMoveing { get; }
        int ReadShorterJogSpeed { get; }
        int ReadShorterPosSpeed { get; }
        int ReadShorterCmdPos { get; }

        // pneumatic

        Task WriteMainGripperStartCommand();
        Task WriteMainGripperStopCommand();
        Task WriteShorterGripperStartCommand();
        Task WriteShorterGripperStopCommand();
        Task WriteShorterCylinderStartCommand();
        Task WriteShorterCylinderStopCommandT();

        bool MainGripperState { get; }
        bool ShorterGripperState { get; }
        bool ShorterCylinderState { get; }


        Task WriteShorterPostionHomingCommand();
        Task WriteRoteryPosPostionHomingCommand();
        Task WriteRoterPostionHomingCommand();

        Task WriteInitializationCommand();
        Task WriteErrorResetCommand();

        //product counter
            int ProductselectedCount { get; }
            int TotalPartCount { get; }
            int GoodPartCount { get; }
            int NotGoodPartCount { get; }
        Task WriteProductionResetCommand();

        //manual vision test

        Task WriteAlignmentTestCommand();
        Task WriteCrackCheckCommand();
        Task WriteDustCheckCommand();

        //Auto Vision Selection

        Task AligmentCheckSelected();
        Task AligmentCheckNotSelected();
        Task CrackCheckSelected();
        Task CrackCheckNotSelected();
        Task DustCheckSelected();
        Task DustCheckNotSelected();
        bool AligmentCheck { get; }
        bool CrackCheck { get; }
        bool DustCheck { get; }
        bool TestResultState { get; }
        bool VisiontestComplete { get; }
}
}