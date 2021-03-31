using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Util;
using Google.Apis.Util.Store;
using MailKit.Net.Imap;
using MailKit.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace VoterAnalysis2.Hubs
{
	public class GmailService
	{
		public async Task GetCredentials()
		{
			const string GMailAccount = "voteranalysis13@gmail.com";

			var clientSecrets = new ClientSecrets
			{
				ClientId = APIKeys.GoogleOAuthID,
				ClientSecret = APIKeys.GoogleOAuthSecret
			};

			var codeFlow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
			{
				DataStore = new FileDataStore("CredentialCacheFolder", false),
				Scopes = new[] { "https://mail.google.com/" },
				ClientSecrets = clientSecrets
			});

			// Note: For a web app, you'll want to use AuthorizationCodeWebApp instead.
			var codeReceiver = new LocalServerCodeReceiver();
			var authCode = new AuthorizationCodeInstalledApp(codeFlow, codeReceiver);

			var credential = await authCode.AuthorizeAsync(GMailAccount, CancellationToken.None);

			if (credential.Token.IsExpired(SystemClock.Default))
				await credential.RefreshTokenAsync(CancellationToken.None);

			var oauth2 = new SaslMechanismOAuth2(credential.UserId, credential.Token.AccessToken);

			using (var client = new ImapClient())
			{
				await client.ConnectAsync("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
				await client.AuthenticateAsync(oauth2);
				await client.DisconnectAsync(true);
			}
		}

	}
}
