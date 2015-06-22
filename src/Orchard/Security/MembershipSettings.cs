using System.Web.Security;

namespace Orchard.Security {
    public class MembershipSettings {
        public MembershipSettings() {
            RequiresUniqueEmail = true;
            PasswordFormat = MembershipPasswordFormat.Hashed;
        }

        public bool RequiresUniqueEmail { get; set; }
        public MembershipPasswordFormat PasswordFormat { get; set; }
    }
}