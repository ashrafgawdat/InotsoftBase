using System.Threading.Tasks;
using Acr.UserDialogs;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Flurl.Http;
using AG.Pos.ApiClient;
using AG.Pos.Core;
using AG.Pos.Localization.Resources;
using AG.Pos.ViewModels.Base;
using Plugin.Connectivity;
using Process = Android.OS.Process;

namespace AG.Pos.Activities
{
    [Activity(Theme = "@style/MyTheme.Splash",
        MainLauncher = true,
        NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        // Launches the startup task
        protected override async void OnResume()
        {
            base.OnResume();
            ApplicationBootstrapper.InitializeIfNeeds<PosXamarinAndroidModule>();
            await CheckInternetAndStartApplication();
        }
         
        public override void OnBackPressed()
        {
            // Prevent the back button from canceling the startup process
        }

        private async Task CheckInternetAndStartApplication()
        {
            if (CrossConnectivity.Current.IsConnected || ApiUrlConfig.IsLocal)
            {
                await StartApplication();
            }
            else
            {
                var isTryAgain = await UserDialogs.Instance.ConfirmAsync(LocalTranslation.NoInternet, LocalTranslation.MessageTitle);
                if (!isTryAgain)
                {
                    App.ExitApplication();
                }

                await CheckInternetAndStartApplication();
            }
        }

        /// <summary>
        ///  Performing some startup work that takes a bit of time
        /// </summary>
        private async Task StartApplication()
        {
            await UserConfigurationManager.GetIfNeedsAsync();
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            UserDialogs.Init(this);
            ConfigureFlurlHttp();
            SetExitAction();
        }

        private static void SetExitAction()
        {
            App.ExitApplication = () =>
            {
                Process.KillProcess(Process.MyPid());
            };
        }

        private static void ConfigureFlurlHttp()
        {
            FlurlHttp.Configure(c =>
            {
                c.HttpClientFactory = new ModernHttpClientFactory();
            });
        }
    }
}