namespace WebAuthenticatorDemo
{
    public static class Constants
    {
        public static string AuthorityUri = "https://mtaspiring-identity-qa.connectintouch.com/";
        public static string AuthorizeUri = AuthorityUri + "connect/authorize";
        public static string TokenUri = AuthorityUri + "connect/token";
        public static string RedirectUri = "gogate.demo.com://";
        public static string ApiUri = "http://localhost:5678/";
        public static string ClientId = "GoGate";
        public static string ClientSecret = null;
        public static string Scope = "idapi";
    }
}
