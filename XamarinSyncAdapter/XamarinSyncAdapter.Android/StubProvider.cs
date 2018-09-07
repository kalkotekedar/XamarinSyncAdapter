using Android.Content;

namespace XamarinSyncAdapter.Droid
{
    [ContentProvider(
        new[] { "com.kalkotekedar.syncadapter.provider" },
        Name = "com.kalkotekedar.syncadapter.StubContentProvider",
        Exported = false,
        Syncable = true)]
    public class StubProvider : ContentProvider
    {
        public override bool OnCreate()
        {
            return true;
        }

        public override string GetType(Android.Net.Uri uri)
        {
            return string.Empty;
        }

        public override Android.Database.ICursor Query(Android.Net.Uri uri, string[] projection, string selection, string[] selectionArgs, string sortOrder)
        {
            return null;
        }

        public override Android.Net.Uri Insert(Android.Net.Uri uri, ContentValues values)
        {
            return null;
        }

        public override int Delete(Android.Net.Uri uri, string selection, string[] selectionArgs)
        {
            return 0;
        }

        public override int Update(Android.Net.Uri uri, ContentValues values, string selection, string[] selectionArgs)
        {
            return 0;
        }
    }
}