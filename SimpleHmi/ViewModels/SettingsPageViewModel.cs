using Prism.Mvvm;
using Prism.Regions;
using SimpleHmi.PlcService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
           
        public SettingsPageViewModel(IPlcService ModPlcService)
        {
            _plcService = ModPlcService;
            this.PropertyChanged += OnPropertyChanged;
        }
        #endregion

        #region Public Method
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
