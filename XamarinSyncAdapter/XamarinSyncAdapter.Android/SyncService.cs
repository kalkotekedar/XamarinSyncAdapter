using Android.App;
using Android.Content;
using Android.OS;

namespace XamarinSyncAdapter.Droid
{
    [Service(Name = "com.kalkotekedar.syncadapter.SyncService", Exported = true, Enabled = true)]
    [IntentFilter(new[] { "android.content.SyncAdapter" })]
    [MetaData("android.content.SyncAdapter", Resource = "@xml/syncadapter")]
    public class SyncService : Service
    {
        static SyncAdapter _syncAdapter = null;
        static object _syncAdapterLock = new object();

        public override void OnCreate()
        {
            base.OnCreate();
            lock (_syncAdapterLock)
            {
                if (_syncAdapter == null)
                    _syncAdapter = new SyncAdapter(ApplicationContext, true);
            }
        }

        public override IBinder OnBind(Intent intent)
        {
            return _syncAdapter.SyncAdapterBinder;
        }
    }
}