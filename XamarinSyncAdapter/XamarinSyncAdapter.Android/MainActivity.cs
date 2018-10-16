using Android.Accounts;
using Android.App;
using Android.Content.PM;
using Android.Content;
using Android.OS;
using Android.Util;
using Prism;
using Prism.Ioc;

namespace XamarinSyncAdapter.Droid
{
    [Activity(Label = "SyncAdapter", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public static string AUTHORITY = "com.kalkotekedar.syncadapter.provider";
        public static string ACCOUNT_TYPE = "com.kalkotekedar.syncadapter";
        public static string ACCOUNT = "SyncAdapter";

        //Sync the data periodically for API level more than 24 standard time is 15 minute and for below that it is 1 Hr
        //Time is in seconds 
        public static long SYNC_INTERVAL = 60L;

        public static Account SyncAccount;

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            SyncAccount = CreateSyncAccount(this);

            //This will set the auto-sync on for all applications
            if (!ContentResolver.MasterSyncAutomatically)
                ContentResolver.MasterSyncAutomatically = true;

            //Set the app auto sync On
            ContentResolver.SetSyncAutomatically(SyncAccount, AUTHORITY, true);

            ContentResolver.AddPeriodicSync(SyncAccount, AUTHORITY, Bundle.Empty, SYNC_INTERVAL);
            
            //This is to force sync on app start
            //var settingsBundle = new Bundle();
            //settingsBundle.PutBoolean(ContentResolver.SyncExtrasManual, true);
            //settingsBundle.PutBoolean(ContentResolver.SyncExtrasExpedited, true);
            //ContentResolver.RequestSync(SyncAccount, AUTHORITY, new Bundle());
            
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App(new AndroidInitializer()));
        }
        
        public static Account CreateSyncAccount(Context context)
        {
            Account newAccount = new Account(ACCOUNT, ACCOUNT_TYPE);
            AccountManager accountManager = (AccountManager)context.GetSystemService(Context.AccountService);
            accountManager.AddAccountExplicitly(newAccount, null, null);
            return newAccount;
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry container)
        {
            // Register any platform specific implementations
        }
    }
}
