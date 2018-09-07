using System;
using Android.Accounts;
using Android.Content;
using Android.OS;

namespace XamarinSyncAdapter.Droid
{
    public class Authenticator : AbstractAccountAuthenticator
    {
        public Authenticator(Context context) : base(context)
        {
        }

        public override Bundle EditProperties(AccountAuthenticatorResponse response, string accountType)
        {
            throw new NotImplementedException();
        }

        public override Bundle AddAccount(AccountAuthenticatorResponse response, string accountType, string authTokenType, string[] requiredFeatures, Bundle options)
        {
            return null;
        }

        public override Bundle ConfirmCredentials(AccountAuthenticatorResponse response, Account account, Bundle options)
        {
            return null;
        }

        public override Bundle GetAuthToken(AccountAuthenticatorResponse response, Account account, string authTokenType, Bundle options)
        {
            throw new NotImplementedException();
        }

        public override string GetAuthTokenLabel(string authTokenType)
        {
            throw new NotImplementedException();
        }

        public override Bundle UpdateCredentials(AccountAuthenticatorResponse response, Account account, string authTokenType, Bundle options)
        {
            throw new NotImplementedException();
        }

        public override Bundle HasFeatures(AccountAuthenticatorResponse response, Account account, string[] features)
        {
            throw new NotImplementedException();
        }
    }
}