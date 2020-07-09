﻿namespace AG.Pos
{
    /// <summary>
    /// Some consts used in the application.
    /// </summary>
    public class AppConsts
    {
        /// <summary>
        /// Default page size for paged requests.
        /// </summary>
        public const int DefaultPageSize = 10;

        /// <summary>
        /// Maximum allowed page size for paged requests.
        /// </summary>
        public const int MaxPageSize = 1000;

        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public const string DefaultPassPhrase = "gsKxGZ012HLL3MI5";

        public const int ResizedMaxProfilPictureBytesUserFriendlyValue = 1024;

        public const int MaxProfilPictureBytesUserFriendlyValue = 5;

        public const string TokenValidityKey = "token_validity_key";

        public static string UserIdentifier = "user_identifier";

        public const string AllowedDomainsCorsPolicyName = "AllowedDomainsCorsPolicy";

        public const string ThemeDefault = "default";
        public const string Theme2 = "theme2";
        public const string Theme8 = "theme8";
        public const string Theme11 = "theme11";

        public class Cache
        {
            public class AllowedDomains
            {
                public const string Key = "Cache.AllowedDomains.Key";
                public const int CacheDurationInSeconds = 10 * 60;
            }
        }
    }
}