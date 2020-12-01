using Prism.Mvvm;
using Prism.Regions;
using SimpleHmi.PlcService;
using SimpleHmi.Utility;
using System.ComponentModel;
using System;
using Prism.Events;
using SimpleHmi.Designer;

namespace SimpleHmi.ViewModels
{
    class SettingsPageViewModel :BindableBase, INavigationAware
    {
        #region private Memeber
        private readonly IPlcService _plcService;
        #endregion

        #region Public member

        public int InletPumpSpeed
        {
            get { return _inletPumpSpeed; }
            set { SetProperty(ref _inletPumpSpeed, value); }
        }
        private int _inletPumpSpeed;

        public int OutletSpeed
        {
            get { return _outletSpeed; }
            set { SetProperty(ref _outletSpeed, value); }
        }

        private int _outletSpeed;

        public object SelectedProduct { get; private set; }

   
        public string strSelectedProduct
        {
            get { return _strSelectedProduct; }
            set { SetProperty(ref _strSelectedProduct, value); }
        }

        private string _strSelectedProduct;
        private DesignPlcService designPlcService;

        public SettingsPageViewModel(IPlcService ModPlcService, IEventAggregator ea)
        {
            _plcService = ModPlcService;
            this.PropertyChanged += OnPropertyChanged;
          
            FileSelectedGlobalEvent.Instance.Subscribe(ProcessFile);

        }

        public SettingsPageViewModel(DesignPlcService designPlcService)
        {
            this.designPlcService = designPlcService;
        }


        #endregion

        #region Public Method

        private void ProcessFile(string SelectedProduct)
        {
             strSelectedProduct = SelectedProduct ;
            Console.WriteLine(strSelectedProduct);
           
        }
        private async void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(OutletSpeed))
            {
                await _plcService.WriteSpeedOutletPump((short)OutletSpeed);
            }
            else if (e.PropertyName == nameof(InletPumpSpeed))
            {
                await _plcService.WriteSpeedInletPump((short)InletPumpSpeed);
            }
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            InletPumpSpeed = _plcService.InletPumpSpeed;
            OutletSpeed = _plcService.OutletPumpSpeed;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }
        #endregion
    }

}
