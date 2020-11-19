using Prism.Commands;
using Prism.Mvvm;
using SimpleHmi.PlcService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace SimpleHmi.ViewModels
{
    class MainPageViewModel : BindableBase
    {
        #region MainView

        #region Private member 

        private IPlcService _plcService;

        #endregion


        #region Public member

        /// <summary>
        /// variable to hold PLC IP Address
        /// </summary>
        
        public string IpAddress
        {
            get { return _ipAddress; }
            set { SetProperty(ref _ipAddress, value); }
        }
        private string _ipAddress;

        /// <summary>
        /// variable to hold Roter Axis Moveing State
        /// </summary>

        public bool RoterMoveingState
        {
            get { return _RoterMoveingState; }
            set { SetProperty(ref _RoterMoveingState, value); }
        }
        private bool _RoterMoveingState;

        /// <summary>
        /// variable to hold Roter Jog Speed
        /// </summary>
        
        public int RoterJogSpeed
        {
            get { return _RoterJogSpeed; }
            set { SetProperty(ref _RoterJogSpeed, value); }
        }
        private int _RoterJogSpeed;

        /// <summary>
        /// variable to hold Roter Positioning Speed
        /// </summary>


        public int RoterPositioningSpeed
        {
            get { return _RoterPositioningSpeed; }
            set { SetProperty(ref _RoterPositioningSpeed, value); }
        }
        private int _RoterPositioningSpeed;

        /// <summary>
        /// variable to hold Roter Commend Position
        /// </summary>
        
        public int RoterCommendposition
        {
            get { return _RoterCommendposition; }
            set { SetProperty(ref _RoterCommendposition, value); }
        }
        private int _RoterCommendposition;

        /// <summary>
        /// variable to hold Rotey position Axis Moveing State
        /// </summary>

        public bool RoteryPosMoveing
        {
            get { return _RoteryPosMoveing; }
            set { SetProperty(ref _RoteryPosMoveing, value); }
        }
        private bool _RoteryPosMoveing;


        /// <summary>
        /// variable to hold Rotey Position  Axis Jog Speed
        /// </summary>

        public int RoteryPosJogSpeed
        {
            get { return _RoteryPosJogSpeed; }
            set { SetProperty(ref _RoteryPosJogSpeed, value); }
        }
        private int _RoteryPosJogSpeed;

        /// <summary>
        /// variable to hold Rotey Position  Axis Positioning Speed
        /// </summary>

        public int RoteryPosPositioningSpeed
        {
            get { return _RoteryPosPositioningSpeed; }
            set { SetProperty(ref _RoteryPosPositioningSpeed, value); }
        }
        private int _RoteryPosPositioningSpeed;

        /// <summary>
        /// variable to hold Rotey Position  Axis Commend Position 
        /// </summary>

        public int RoteryPosCommendposition
        {
            get { return _RoteryPosCommendposition; }
            set { SetProperty(ref _RoteryPosCommendposition, value); }
        }
        private int _RoteryPosCommendposition;

        /// <summary>
        /// variable to hold Shorter Axis Moveing State
        /// </summary>

        public bool ShorterMoveing
        {
            get { return _ShorterMoveing; }
            set { SetProperty(ref _ShorterMoveing, value); }
        }
        private bool _ShorterMoveing;

        /// <summary>
        /// variable to hold Shorter Jog Speeed
        /// </summary>

        public int ShorterJogSpeed
        {
            get { return _ShorterJogSpeed; }
            set { SetProperty(ref _ShorterJogSpeed, value); }
        }
        private int _ShorterJogSpeed;

        /// <summary>
        /// variable to hold Shorter Positioning Speeed
        /// </summary>

        public int ShorterPositioningSpeed
        {
            get { return _ShorterPositioningSpeed; }
            set { SetProperty(ref _ShorterPositioningSpeed, value); }
        }
        private int _ShorterPositioningSpeed;

        /// <summary>
        /// variable to hold Shorter Commend Position
        /// </summary>

        public int ShorterCommendposition
        {
            get { return _ShorterCommendposition; }
            set { SetProperty(ref _ShorterCommendposition, value); }
        }
        private int _ShorterCommendposition;


        /// <summary>
        /// variable to hold Main Gripper State
        /// </summary>
        /// 
        public bool MainGripperState
        {
            get { return _MainGripperState; }
            set { SetProperty(ref _MainGripperState, value); }
        }
        private bool _MainGripperState;

        /// <summary>
        /// variable to hold Shorter Gripper State
        /// </summary>
        
        public bool ShorterGripperState
        {
            get { return _ShorterGripperState; }
            set { SetProperty(ref _ShorterGripperState, value); }
        }
        private bool _ShorterGripperState;

        /// <summary>
        /// variable to hold Shorter Cylinder State
        /// </summary>

        public bool ShorterCylinderState
        {
            get { return _ShorterCylinderState; }
            set { SetProperty(ref _ShorterCylinderState, value); }
        }
        private bool _ShorterCylinderState;

        /// <summary>
        /// variable to hold Product Selected value
        /// </summary>

        public string Productselected
        {
            get {  return _Productselected; }
            set { SetProperty( ref _Productselected, value); }
        }
        private string _Productselected;

        /// <summary>
        /// variable to hold Total part Value
        /// </summary>
        
        public int TotalPart
        {
            get { return _TotalPart; }
            set { SetProperty(ref _TotalPart, value); }
        }
        private int _TotalPart;

        /// <summary>
        /// variable to hold Good part Value
        /// </summary>

        public int GoodPart
        {
            get { return _GoodPart; }
            set { SetProperty(ref _GoodPart, value); }
        }
        private int _GoodPart;

        /// <summary>
        /// variable to hold Not Good part Value
        /// </summary>

        public int NotGoodPart
        {
            get { return _NotGoodPart; }
            set { SetProperty(ref _NotGoodPart, value); }
        }
        private int _NotGoodPart;

        /// <summary>
        /// variable to hold Aligment Check State
        /// </summary>

        public bool AligmentCheckState
        {
            get { return _AligmentCheckState; }
            set { SetProperty(ref _AligmentCheckState, value); }
        }
        private bool _AligmentCheckState;

        /// <summary>
        /// variable to hold Crack Check State
        /// </summary>

        public bool CrackCheckState
        {
            get { return _CrackCheckState; }
            set { SetProperty(ref _CrackCheckState, value); }
        }
        private bool _CrackCheckState;

        /// <summary>
        /// variable to hold Dust Check State
        /// </summary>

        public bool DustCheckState
        {
            get { return _DustCheckState; }
            set { SetProperty(ref _DustCheckState, value); }
        }

        private bool _DustCheckState;

        /// <summary>
        /// Command to Connect PLC
        /// </summary>
        public ICommand ConnectCommand { get; private set; }

        /// <summary>
        /// Command to Disconnect PLC
        /// </summary>
        public ICommand DisconnectCommand { get; private set; }

        /// <summary>
        /// Command to Auto Mode
        /// </summary>

        public ICommand StartCommand { get; private set; }

        /// <summary>
        /// Commend for Manual Mode
        /// </summary>
        public ICommand StopCommand { get; private set; }

        /// <summary>
        /// Commend for Roter Axis Jogging Positive Start
        /// </summary>
        public ICommand RoterJogPositveStartCommand { get; private set; }
        /// <summary>
        /// Commend for Roter Axis Jogging Positive Stop
        /// </summary>
        public ICommand RoterJogPositveStopCommand { get; private set; }

        /// <summary>
        /// Commend for Roter Axis Negative Positive Start
        /// </summary>

        public ICommand RoterJogNegativeStartCommand { get; private set; }

        /// <summary>
        /// Commend for Roter Axis Negative Positive Stop
        /// </summary>

        public ICommand RoterJogNegativeStopCommand { get; private set; }

        /// <summary>
        /// Commend for Roter Axis Position Start
        /// </summary>

        public ICommand RoterPostionStartCommand { get; private set; }

        /// <summary>
        /// Commend for Roter Position Axis Jogging Positive Start
        /// </summary>

        public ICommand RoteryPosJogPositveStartCommand { get; private set; }

        /// <summary>
        /// Commend for Roter Position Axis Jogging Positive Stop
        /// </summary>

        public ICommand RoteryPosJogPositveStopCommand { get; private set; }

        /// <summary>
        /// Commend for Roter Position Axis Jogging Negative Start
        /// </summary>

        public ICommand RoteryPosJogNegativeStartCommand { get; private set; }

        /// <summary>
        /// Commend for Roter Position Axis Jogging Negative Stop
        /// </summary>
        public ICommand RoteryPosJogNegativeStopCommand { get; private set; }
        /// <summary>
        /// Commend for Roter Position Axis Psoitione Start
        /// </summary>

        public ICommand RoteryPosPostionStartCommand { get; private set; }

        /// <summary>
        /// Commend for Shorter Axis Jogging Positive Stop
        /// </summary>
        
        public ICommand ShorterJogPositveStartCommand { get; private set; }

        /// <summary>
        /// Commend for Shorter  Axis Jogging Psoitive Start
        /// </summary>

        public ICommand ShorterJogPositveStopCommand { get; private set; }

        /// <summary>
        /// Commend for Shorter  Axis Jogging Negative Start
        /// </summary>

        public ICommand ShorterJogNegativeStartCommand { get; private set; }

        /// <summary>
        /// Commend for Shorter  Axis Jogging Negative Stop
        /// </summary>

        public ICommand ShorterJogNegativeStopCommand { get; private set; }

        /// <summary>
        /// Commend for Shorter  Axis Position Start
        /// </summary>

        public ICommand ShorterPostionStartCommand { get; private set; }

        /// <summary>
        /// Commend for Main Gripper Start
        /// </summary>
        public ICommand MainGripperStartCommand { get; private set; }

        /// <summary>
        /// Commend for Main Gripper Stop
        /// </summary>
               
        public ICommand MainGripperStopCommand { get; private set; }

        /// <summary>
        /// Commend for Shorter Gripper Start
        /// </summary>

        public ICommand ShorterGripperStartCommand { get; private set; }

        /// <summary>
        /// Commend for Shorter Gripper Stop
        /// </summary>

        public ICommand ShorterGripperStopCommand { get; private set; }

        /// <summary>
        /// Commend for Shorter Cylinder Start
        /// </summary>

        public ICommand ShorterCylinderStartCommand { get; private set; }

        /// <summary>
        /// Commend for Shorter Cylinder Stop
        /// </summary>
        public ICommand ShorterCylinderStopCommand { get; private set; }

        /// <summary>
        /// Commend for Shorter Postion Homing
        /// </summary>

        public ICommand ShorterPostionHomingCommand { get; private set; }

        /// <summary>
        /// Commend for Rotery Postion Homing
        /// </summary>

        public ICommand RoteryPosPostionHomingCommand { get; private set; }

        /// <summary>
        /// Commend for Rotery Axis Homing
        /// </summary>

        public ICommand RoterPostionHomingCommand { get; private set; }

        /// <summary>
        /// Commend for Production Reset
        /// </summary>


        public ICommand ProductionResetCommand { get; private set; }


        /// <summary>
        /// Commend for Manual Alignment test
        /// </summary>

        public ICommand AlignmentTestCommand { get; private set; }

        /// <summary>
        /// Commend for Manual Crack test
        /// </summary>


        public ICommand CrackCheckCommand { get; private set; }

        /// <summary>
        /// Commend for Manual Dust test
        /// </summary>
        
        public ICommand DustCheckCommand { get; private set; }

        /// <summary>
        /// Commend for Auto Aligment Check Selected
        /// </summary>

        public ICommand AligmentCheckSelectedCommand { get; private set; }

        /// <summary>
        /// Commend for Auto Aligment Check Not Selected
        /// </summary>

        public ICommand AligmentCheckNotSelectedCommand { get; private set; }

        /// <summary>
        /// Commend for Auto Crack Check  Selected
        /// </summary>

        public ICommand CrackCheckSelectedCommand { get; private set; }

        /// <summary>
        /// Commend for Auto Crack Check Not Selected
        /// </summary>

        public ICommand CrackCheckNotSelectedCommand { get; private set; }

        /// <summary>
        /// Commend for Auto Dust Check  Selected
        /// </summary>

        public ICommand DustCheckSelectedCommand { get; private set; }

        /// <summary>
        /// Commend for Auto Dust Check Not Selected
        /// </summary>

        public ICommand DustCheckNotSelectedCommand { get; private set; }





        #endregion


        #region Private Method
        public MainPageViewModel(IPlcService ModPlcService)
        {
            ///<summary>
            ///PLC Modbus service 
            ///</summary>
            
            _plcService = ModPlcService;

            /// <summary>
            /// Delegate for Connect Commend
            /// </summary>
            ConnectCommand = new DelegateCommand(Connect);
            /// <summary>
            /// Delegate for DisConnect Commend
            /// </summary>
            DisconnectCommand = new DelegateCommand(Disconnect);
            /// <summary>
            /// Delegate for Auto Mode Commend
            /// </summary>
            StartCommand = new DelegateCommand(async () => { await Start(); });
            /// <summary>
            /// Delegate for Manual Mode Commend
            /// </summary>
            StopCommand = new DelegateCommand(async () => { await Stop(); });
            /// <summary>
            /// Delegate for Roter Jog Positve Start Command
            /// </summary>
            RoterJogPositveStartCommand = new DelegateCommand(async () => { await RoterJogPositveStartT(); });
            /// <summary>
            /// Delegate for Roter Jog Positve Stop Command
            /// </summary>
            RoterJogPositveStopCommand = new DelegateCommand(async () => { await RoterJogPositveStopT(); });
            /// <summary>
            /// Delegate for Roter Jog Negative Start Command
            /// </summary>
            RoterJogNegativeStartCommand = new DelegateCommand(async () => { await RoterJogNegativeStartT(); });
            /// <summary>
            /// Delegate for Roter Jog Negative Stop Command
            /// </summary>
            RoterJogNegativeStopCommand = new DelegateCommand(async () => { await RoterJogNegativeStopT(); });
            /// <summary>
            /// Delegate for Roter Axis Position Start Command
            /// </summary>
            RoterPostionStartCommand = new DelegateCommand(async () => { await RoterPostionStartCommandT(); });
            /// <summary>
            /// Delegate for Rotery Position Jog Positve Start Command
            /// </summary>
            RoteryPosJogPositveStartCommand = new DelegateCommand(async () => { await RoteryPosJogPositveStartT(); });
            /// <summary>
            /// Delegate for Rotery Position Jog Positve Stop Command
            /// </summary>
            RoteryPosJogPositveStopCommand = new DelegateCommand(async () => { await RoteryPosJogPositveStopT(); });
            /// <summary>
            /// Delegate for Rotery Position Jog Negative Start Command
            /// </summary>
            RoteryPosJogNegativeStartCommand = new DelegateCommand(async () => { await RoteryPosJogNegativeStartT(); });
            /// <summary>
            /// Delegate for Rotery Position Jog Negative Stop Command
            /// </summary>
            RoteryPosJogNegativeStopCommand = new DelegateCommand(async () => { await RoteryPosJogNegativeStopT(); });
            /// <summary>
            /// Delegate for Rotery Position axis Positioning  Start Command
            /// </summary>
            RoteryPosPostionStartCommand = new DelegateCommand(async () => { await RoteryPosPostionStartCommandT(); });

            /// <summary>
            /// Delegate for Shorter Jog Positve Start Command
            /// </summary>
            ShorterJogPositveStartCommand = new DelegateCommand(async () => { await ShorterJogPositveStartT(); });
            /// <summary>
            /// Delegate for Shorter  Jog Positve Stop Command
            /// </summary>
            ShorterJogPositveStopCommand = new DelegateCommand(async () => { await ShorterJogPositveStopT(); });
            /// <summary>
            /// Delegate for Shorter Jog Negative Start Command
            /// </summary>

            ShorterJogNegativeStartCommand = new DelegateCommand(async () => { await ShorterJogNegativeStartT(); });
            /// <summary>
            /// Delegate for Shorter Jog Negative Stop Command
            /// </summary>
            ShorterJogNegativeStopCommand = new DelegateCommand(async () => { await ShorterJogNegativeStopT(); });
            /// <summary>
            /// Delegate for Shorter axis Postiioning Start Command
            /// </summary>
            ShorterPostionStartCommand = new DelegateCommand(async () => { await ShorterPostionStartCommandT(); });

            /// <summary>
            /// Delegate for MAin Gripper Start Command
            /// </summary>
            /// 
            MainGripperStartCommand = new DelegateCommand(async () => { await MainGripperStartCommandT(); });
            /// <summary>
            /// Delegate for MAin Gripper stop Command
            /// </summary>
            /// 
            MainGripperStopCommand = new DelegateCommand(async () => { await MainGripperStopCommandT(); });
            /// <summary>
            /// Delegate for Shorter Gripper Start Command
            /// </summary>
            /// 
            ShorterGripperStartCommand = new DelegateCommand(async () => { await ShorterGripperStartCommandT(); });
            /// <summary>
            /// Delegate for Shorter Gripper Stop Command
            /// </summary>
            /// 
            ShorterGripperStopCommand = new DelegateCommand(async () => { await ShorterGripperStopCommandT(); });
            /// <summary>
            /// Delegate for Shorter Cylinder Start Command
            /// </summary>
            /// 
            ShorterCylinderStartCommand = new DelegateCommand(async () => { await ShorterCylinderStartCommandT(); });
            /// <summary>
            /// Delegate for Shorter Cylinder stop Command
            /// </summary>
            /// 
            ShorterCylinderStopCommand = new DelegateCommand(async () => { await ShorterCylinderStopCommandT(); });

            /// <summary>
            /// Delegate for Shorter Homing Command
            /// </summary>
            /// 
            ShorterPostionHomingCommand = new DelegateCommand(async () => { await ShorterPostionHomingCommandT(); });

            /// <summary>
            /// Delegate for Rotery Position Homing Command
            /// </summary>
            /// 
            RoteryPosPostionHomingCommand = new DelegateCommand(async () => { await RoteryPosPostionHomingCommandT(); });

            /// <summary>
            /// Delegate for Rotery Homing Command
            /// </summary>
            /// 
            RoterPostionHomingCommand = new DelegateCommand(async () => { await RoterPostionHomingCommandT(); });

            /// <summary>
            /// Delegate for  Production Reset Command
            /// </summary>
            /// 
            ProductionResetCommand = new DelegateCommand(async () => { await ProductionResetCommandT(); });
            /// <summary>
            /// Delegate for Manual Alignment Test Command
            /// </summary>
            /// 
            AlignmentTestCommand = new DelegateCommand(async () => { await AlignmentTestCommandT(); });
            /// <summary>
            /// Delegate for Manual Crack Test Command
            /// </summary>
            /// 
            CrackCheckCommand = new DelegateCommand(async () => { await CrackCheckCommandT(); });
            /// <summary>
            /// Delegate for Manual Dust Test Command
            /// </summary>
            /// 
            DustCheckCommand = new DelegateCommand(async () => { await DustCheckCommandT(); });
            /// <summary>
            /// Delegate for Auto  Alignment Check Selected Command
            /// </summary>
            /// 
            AligmentCheckSelectedCommand = new DelegateCommand(async () => { await AligmentCheckSelectedT(); });
            /// <summary>
            /// Delegate for Auto  Alignment Check Not Selected Command
            /// </summary>
            /// 
            AligmentCheckNotSelectedCommand = new DelegateCommand(async () => { await AligmentCheckNotSelectedT(); });
            /// <summary>
            /// Delegate for Auto  Crack Check  Selected Command
            /// </summary>
            /// 
            CrackCheckSelectedCommand = new DelegateCommand(async () => { await CrackCheckSelectedT(); });
            /// <summary>
            /// Delegate for Auto  Crack Check Not Selected Command
            /// </summary>
            /// 
            CrackCheckNotSelectedCommand = new DelegateCommand(async () => { await CrackCheckNotSelectedT(); });
            /// <summary>
            /// Delegate for Auto  Dust Check  Selected Command
            /// </summary>
            /// 
            DustCheckSelectedCommand = new DelegateCommand(async () => { await DustCheckSelectedT(); });
            /// <summary>
            /// Delegate for Auto  Dust Check Not Selected Command
            /// </summary>
            /// 
            DustCheckNotSelectedCommand = new DelegateCommand(async () => { await DustCheckNotSelectedT(); });
            IpAddress = "127.0.0.1";

            OnPlcServiceValuesRefreshed(null, null);
            this.PropertyChanged += OnPropertyChanged;
            _plcService.ValuesRefreshed += OnPlcServiceValuesRefreshed;
        }


        /// <summary>
        /// Method used to Send Speed and position value to PLC if there value is changed
        /// </summary>

        private async void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(RoterJogSpeed))
            {
                await _plcService.WriteRoterJogSpeed((short)RoterJogSpeed);
            }
            else if (e.PropertyName == nameof(RoterPositioningSpeed))
            {
                await _plcService.WriteRoterPositioningSpeed((short)RoterPositioningSpeed);
            }
            else if (e.PropertyName == nameof(RoterCommendposition))
            {
                await _plcService.WriteRoterCommendposition((short)RoterCommendposition);
            }
            else if (e.PropertyName == nameof(RoteryPosJogSpeed))
            {
                await _plcService.WriteRoteryPosJogSpeed((short)RoteryPosJogSpeed);
            }
            else if (e.PropertyName == nameof(RoteryPosPositioningSpeed))
            {
                await _plcService.WriteRoteryPosPositioningSpeed((short)RoteryPosPositioningSpeed);
            }
            else if (e.PropertyName == nameof(RoteryPosCommendposition))
            {
                await _plcService.WriteRoteryPosCommendposition((short)RoteryPosCommendposition);
            }
            else if (e.PropertyName == nameof(ShorterJogSpeed))
            {
                await _plcService.WriteShorterJogSpeed((short)ShorterJogSpeed);
            }
            else if (e.PropertyName == nameof(ShorterPositioningSpeed))
            {
                await _plcService.WriteShorterPositioningSpeed((short)ShorterPositioningSpeed);
            }
            else if (e.PropertyName == nameof(ShorterCommendposition))
            {
                await _plcService.WriteShorterCommendposition((short)ShorterCommendposition);
            }

        }

        /// <summary>
        /// Method used to refresh PLC reciveing value
        /// </summary>


        private void OnPlcServiceValuesRefreshed(object sender, EventArgs e)
        {

            RoterMoveingState = _plcService.RoterMoveing;
            RoterJogSpeed = _plcService.ReadRoterJogSpeed;
            RoterPositioningSpeed = _plcService.ReadRoterPosSpeed;
            RoterCommendposition = _plcService.ReadRoterCmdPos;
            RoteryPosMoveing = _plcService.RoteryPosMoveing;
            RoteryPosJogSpeed = _plcService.ReadRoteryPosJogSpeed;
            RoteryPosPositioningSpeed = _plcService.ReadRoteryPosPosSpeed;
            RoteryPosCommendposition = _plcService.ReadRoteryPosCmdPos;
            ShorterMoveing = _plcService.ShorterMoveing;
            ShorterJogSpeed = _plcService.ReadShorterJogSpeed;
            ShorterPositioningSpeed = _plcService.ReadShorterPosSpeed;
            ShorterCommendposition = _plcService.ReadShorterCmdPos;
            MainGripperState = _plcService.MainGripperState;
            ShorterGripperState = _plcService.ShorterGripperState;
            ShorterCylinderState = _plcService.ShorterCylinderState;

            Productselected = SelectedProduct(_plcService.ProductselectedCount);
            TotalPart = _plcService.TotalPartCount;
            GoodPart = _plcService.GoodPartCount;
            NotGoodPart = _plcService.NotGoodPartCount;

            AligmentCheckState = _plcService.AligmentCheck;
            CrackCheckState = _plcService.CrackCheck;
            DustCheckState =_plcService.DustCheck;

        }

        /// <summary>
        /// Method used to Connect PLC
        /// </summary

        private void Connect()
        {
            _plcService.Connect(IpAddress, 0, 1);
        }

        /// <summary>
        /// Method used to DisConnect PLC
        /// </summary

        private void Disconnect()
        {
            _plcService.Disconnect();
        }

        /// <summary>
        /// Method used to Auto Mode
        /// </summary

        private async Task Start()
        {
            await _plcService.WriteStart();
        }

        /// <summary>
        /// Method used to Manual Mode
        /// </summary
        private async Task Stop()
        {
            await _plcService.WriteStop();
        }

        /// <summary>
        /// Method used to Roter Axis Jog Positive start 
        /// </summary

        private async Task RoterJogPositveStartT()
        {
            await _plcService.WriteRoterJogPositveStart();
        }


        /// <summary>
        /// Method used to Roter Axis Jog Positive Stop 
        /// </summary

        private async Task RoterJogPositveStopT()
        {
            await _plcService.WriteRoterJogPositveStop();
        }


        /// <summary>
        /// Method used to Roter Axis Jog Negative start 
        /// </summary

        private async Task RoterJogNegativeStartT()
        {
            await _plcService.WriteRoterJogNegativeStart();
        }


        /// <summary>
        /// Method used to Roter Axis Jog Negative stop 
        /// </summary

        private async Task RoterJogNegativeStopT()
        {
            await _plcService.WriteRoterJogNegativeStop();
        }


        /// <summary>
        /// Method used to Roter Axis Position start
        /// </summary

        private async Task RoterPostionStartCommandT()
        {
            await _plcService.WriteRoterPostionStartCommand();
        }


        /// <summary>
        /// Method used to Rotery Pos Axis Jog Positive start 
        /// </summary

        private async Task RoteryPosJogPositveStartT()
        {
            await _plcService.WriteRoteryPosJogPositveStart();
        }


        /// <summary>
        /// Method used to Roter Axis Jog Positive Stop 
        /// </summary

        private async Task RoteryPosJogPositveStopT()
        {
            await _plcService.WriteRoteryPosJogPositveStop();
        }


        /// <summary>
        /// Method used to Roter Axis Jog Negative start 
        /// </summary

        private async Task RoteryPosJogNegativeStartT()
        {
            await _plcService.WriteRoteryPosJogNegativeStart();
        }


        /// <summary>
        /// Method used to Roter Axis Jog Negative start 
        /// </summary

        private async Task RoteryPosJogNegativeStopT()
        {
            await _plcService.WriteRoteryPosJogNegativeStop();
        }


        /// <summary>
        /// Method used to Roter Axis Jog Positive start 
        /// </summary

        private async Task RoteryPosPostionStartCommandT()
        {
            await _plcService.WriteRoteryPosPostionStartCommand();
        }

        private async Task ShorterJogPositveStartT()
        {
            await _plcService.WriteShorterJogPositveStart();
        }

        private async Task ShorterJogPositveStopT()
        {
            await _plcService.WriteShorterJogPositveStop();
        }

        private async Task ShorterJogNegativeStartT()
        {
            await _plcService.WriteShorterJogNegativeStart();
        }

        private async Task ShorterJogNegativeStopT()
        {
            await _plcService.WriteShorterJogNegativeStop();
        }

        private async Task ShorterPostionStartCommandT()
        {
            await _plcService.WriteShorterPostionStartCommand();
        }

        private async Task MainGripperStartCommandT()
        {
            await _plcService.WriteMainGripperStartCommand();
        }

        private async Task MainGripperStopCommandT()
        {
            await _plcService.WriteMainGripperStopCommand();
        }

        private async Task ShorterGripperStartCommandT()
        {
            await _plcService.WriteShorterGripperStartCommand();
        }

        private async Task ShorterGripperStopCommandT()
        {
            await _plcService.WriteShorterGripperStopCommand();
        }

        private async Task ShorterCylinderStartCommandT()
        {
            await _plcService.WriteShorterCylinderStartCommand();
        }

        private async Task ShorterCylinderStopCommandT()
        {
            await _plcService.WriteShorterCylinderStopCommandT();
        }

        private async Task ShorterPostionHomingCommandT()
        {
            await _plcService.WriteShorterPostionHomingCommand();
        }

        private async Task RoteryPosPostionHomingCommandT()
        {
            await _plcService.WriteRoteryPosPostionHomingCommand();
        }

        private async Task RoterPostionHomingCommandT()
        {
            await _plcService.WriteRoterPostionHomingCommand();
        }

        private async Task ProductionResetCommandT()
        {
            await _plcService.WriteProductionResetCommand();
        }

        private async Task AlignmentTestCommandT()
        {
            await _plcService.WriteAlignmentTestCommand();
        }

        private async Task CrackCheckCommandT()
        {
            await _plcService.WriteCrackCheckCommand();
        }

        private async Task DustCheckCommandT()
        {
            await _plcService.WriteDustCheckCommand();
        }

        private async Task AligmentCheckSelectedT()
        {
            await _plcService.AligmentCheckSelected();
        }

        private async Task AligmentCheckNotSelectedT()
        {
            await _plcService.AligmentCheckNotSelected();
        }

        private async Task CrackCheckSelectedT()
        {
            await _plcService.CrackCheckSelected();
        }

        private async Task CrackCheckNotSelectedT()
        {
            await _plcService.CrackCheckNotSelected();
        }

        private async Task DustCheckSelectedT()
        {
            await _plcService.DustCheckSelected();
        }

        private async Task DustCheckNotSelectedT()
        {
            await _plcService.DustCheckNotSelected();
        }

        private string SelectedProduct(int productselectioncode)
        {
            string result= "Select Product";
            if (productselectioncode == 1)
            {
                result= Constant.Constant.ProductSelectedHB2232;
            }

            else if (productselectioncode == 2)
            {
                result = Constant.Constant.ProductSelectedIL2022;
            }

            else if (productselectioncode == 3)
            {
                result = Constant.Constant.ProductSelectedLV1925;
            }
            else if (productselectioncode == 4)
            {
                result = Constant.Constant.ProductSelectedMC1425;
            }
            else if (productselectioncode == 5)
            {
                result = Constant.Constant.ProductSelectedMM1018;
            }
            else if (productselectioncode == 6)
            {
                result = Constant.Constant.ProductSelectedMO1422;
            }
            else if (productselectioncode == 7)
            {
                result = Constant.Constant.ProductSelectedRM1318;
            }
            else if (productselectioncode == 8)
            {
                result = Constant.Constant.ProductSelectedSM1322;
            }
            else if (productselectioncode == 9)
            {
                result = Constant.Constant.ProductSelectedUM0018H;
            }
            else if (productselectioncode == 10)
            {
                result = Constant.Constant.ProductSelectedUM0018HR;
            }
            else if (productselectioncode == 11)
            {
                result = Constant.Constant.ProductSelectedUM0018M;
            }
            return result;
        }

        #endregion

        #endregion
    }
}
