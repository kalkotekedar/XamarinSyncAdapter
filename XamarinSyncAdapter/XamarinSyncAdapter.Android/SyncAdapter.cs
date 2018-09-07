using Android.Accounts;
using Android.Content;
using Android.OS;

namespace XamarinSyncAdapter.Droid
{
    public class SyncAdapter : AbstractThreadedSyncAdapter
    {
        ContentResolver _contentResolver;

        public SyncAdapter(Context context, bool autoInitialize) : base(context, autoInitialize)
        {
            _contentResolver = context.ContentResolver;
        }

        // For Android 3.0 compat
        public SyncAdapter(Context context, bool autoInitialize, bool allowParallelSyncs)
            : base(context, autoInitialize, allowParallelSyncs)
        {
            _contentResolver = context.ContentResolver;
        }

        public override void OnPerformSync(Account account, Bundle extras, string authority, ContentProviderClient
            provider, SyncResult syncResult)
        {
            // do the sync functionality here
        }
    }
}