using System;


namespace Angular.AuthServer.UserManagementExtension
{
    public static class GuidExt
    {
    public static Guid ToGuid(this string s)
        {
            Guid g;
            if (!String.IsNullOrWhiteSpace(s) &&
                Guid.TryParse(s, out g))
            {
                return g;
            }
            
            return Guid.Empty;
        }
    }
}