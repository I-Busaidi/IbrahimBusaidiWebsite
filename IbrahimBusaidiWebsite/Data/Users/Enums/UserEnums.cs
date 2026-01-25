namespace IbrahimBusaidiWebsite.Data.Users.Enums
{
    public class UserEnums
    {
        public enum AddressType
        {
            Shipping = 0,
            Billing = 1
        }

        public enum PrefLanguage
        {
            English = 0,
            Arabic = 1
        }

        public enum MfaMethod
        {
            None = 0,
            Email = 1,
            Sms = 2,
            AuthApp = 3
        }
    }
}
