using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using AG.Pos.Authorization.Users;
using AG.Pos.MultiTenancy;

namespace AG.Pos.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}