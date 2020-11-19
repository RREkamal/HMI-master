using Prism.Mvvm;
using SimpleHmi.PlcService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHmi.ViewModels
{
    class HmiStatusBarViewModel : BindableBase
    {
        #region Private Memeber
        private readonly IPlcService _plcService;
        #endregion

        #region Public memeber
        public ConnectionStates ConnectionState
        {
            get { return _connectionState; }
            set { SetProperty(ref _connectionState, value); }
        }
        private ConnectionStates _connectionState;

        public TimeSpan ScanTime
        {
            get { return _scanTime; }
            set { SetProperty(ref _scanTime, value); }
        }
        private TimeSpan _scanTime;

        public MachineState MachineState
        {
            get { return _machineState; }
            set { SetProperty(ref _machineState, value); }
        }
        private MachineState _machineState;

        public bool TestResultState
        {
            get { return _TestResultState; }
            set { SetProperty(ref _TestResultState, value); }
        }

        private bool _TestResultState;

        public string resultpath
        {
            get { return _resultpath; }
            set
            {
                SetProperty(ref _resultpath, value);
            }
        }
        private string _resultpath;

        public bool VisiontestComplete
        {
            get { return _VisiontestComplete; }
            set { SetProperty(ref _VisiontestComplete, value); }
        }

        private bool _VisiontestComplete;
        #endregion

        #region Public Method

        public HmiStatusBarViewModel(IPlcService ModPlcService)
        {
            _plcService = ModPlcService;
            _plcService.ValuesRefreshed += OnPlcServiceValuesRefreshed;
            OnPlcServiceValuesRefreshed(null, EventArgs.Empty);
        }

        private void OnPlcServiceValuesRefreshed(object sender, EventArgs e)
        {
            ConnectionState = _plcService.ConnectionState;
            ScanTime = _plcService.ScanTime;
            MachineState = _plcService.MachineState;
            TestResultState = VisionCheckresult(_plcService.TestResultState, _plcService.VisiontestComplete);
            resultpath = VisionTestresult(_plcService.TestResultState, _plcService.VisiontestComplete, ConnectionState);
        }

        private string VisionTestresult(bool test_result,bool Vision_test_Complete, ConnectionStates ConnectionStates)
        {
            string result = "Waiting !!!!";
            if (ConnectionStates == ConnectionStates.Online)
            {
                if (test_result && Vision_test_Complete)
                {
                    result = "Fail";
                }
                else if (!test_result)
                    result = "Pass";
            }
            else
            { result = "Please Connect  !!"; }
            return result;
        }
        private bool VisionCheckresult(bool test_result, bool Vision_test_Complete)
        {
            bool result = false;
            if (test_result && Vision_test_Complete)
            {
                result = true;
            }
            else if (!test_result && Vision_test_Complete)
                result = false;

            return result;
        }


        #endregion
    }
}
