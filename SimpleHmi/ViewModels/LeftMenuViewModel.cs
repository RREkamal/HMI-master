using Prism.Commands;
using Prism.Regions;
using SimpleHmi.Infrastructure;
using SimpleHmi.PlcService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleHmi.ViewModels
{
    class LeftMenuViewModel
    {
        #region Private member
        private readonly IRegionManager _regionManager;

        private readonly IPlcService _plcService;

        #endregion

        #region public member
        public ICommand NavigateToMainPageCommand { get; private set; }

        public ICommand NavigateToSettingsPageCommand { get; private set; }

        public ICommand InitializationCommand { get; private set; }

        public ICommand ErrorResetCommand { get; private set; }

        #endregion


        #region Private Method
        public LeftMenuViewModel(IRegionManager regionManager, IPlcService ModPlcService)
        {
            _regionManager = regionManager;
            _plcService = ModPlcService;

            InitializationCommand = new DelegateCommand(async () => { await InitializationCommandT(); });
            ErrorResetCommand = new DelegateCommand(async () => { await ErrorResetCommandT(); });

            NavigateToMainPageCommand = new DelegateCommand(() => NavigateTo("MainPage"));
            NavigateToSettingsPageCommand = new DelegateCommand(() => NavigateTo("SettingsPage"));
        }

        private void NavigateTo(string url)
        {
            _regionManager.RequestNavigate(Regions.ContentRegion, url);
        }

        private async Task InitializationCommandT()
        {
            await _plcService.WriteInitializationCommand();
        }

        private async Task ErrorResetCommandT()
        {
            await _plcService.WriteErrorResetCommand();
        }



            #endregion
        }
}
