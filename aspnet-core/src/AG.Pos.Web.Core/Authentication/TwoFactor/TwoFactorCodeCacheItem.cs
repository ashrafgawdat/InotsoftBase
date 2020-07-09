using System;

namespace AG.Pos.Web.Authentication.TwoFactor
{
    [Serializable]
    public class TwoFactorCodeCacheItem
    {
        public const string CacheName = "AppTwoFactorCodeCache";

        public string Code { get; set; }

        public TwoFactorCodeCacheItem()
        {
            
        }

        public TwoFactorCodeCacheItem(string code)
        {
            Code = code;
        }
    }
}