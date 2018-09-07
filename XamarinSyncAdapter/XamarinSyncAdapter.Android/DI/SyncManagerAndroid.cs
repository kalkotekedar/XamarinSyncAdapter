using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinSyncAdapter.Interface;

namespace XamarinSyncAdapter.Droid.DI
{
    class SyncManagerAndroid : ISyncManager
    {
        public SyncManagerAndroid()
        {
        }

        public void SyncLocalData()
        {
            ContentResolver.RequestSync(MainActivity.SyncAccount, MainActivity.AUTHORITY, Bundle.Empty);
        }
    }
}