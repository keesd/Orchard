using Orchard.ContentManagement;

namespace Orchard.Users.Models {
    public class PasswordPolicySettingsPart : ContentPart {
        public bool Enabled {
            get { return this.Retrieve(x => x.Enabled); }
            set { this.Store(x => x.Enabled, value); }
        }

        public int MinPasswordLength{
            get { return this.Retrieve(x => x.MinPasswordLength); }
            set { this.Store(x => x.MinPasswordLength, value); }
        }

        public bool EnablePasswordReset{
            get { return this.Retrieve(x => x.EnablePasswordReset); }
            set { this.Store(x => x.EnablePasswordReset, value); }
        }

        public bool RequireNummericChars{
            get { return this.Retrieve(x => x.RequireNummericChars); }
            set { this.Store(x => x.RequireNummericChars, value); }
        }
        public bool RequireSpecialChars{
            get { return this.Retrieve(x => x.RequireSpecialChars); }
            set { this.Store(x => x.RequireSpecialChars, value); }
        }

        public bool RequireUpperAndLowerCaseChars {
            get { return this.Retrieve(x => x.RequireUpperAndLowerCaseChars); }
            set { this.Store(x => x.RequireUpperAndLowerCaseChars, value); }
        }

        public int PasswordExpirationInDays{
            get { return this.Retrieve(x => x.PasswordExpirationInDays); }
            set { this.Store(x => x.PasswordExpirationInDays, value); }
        }

        public int ExpirationWarningDaysAhead{
            get { return this.Retrieve(x => x.ExpirationWarningDaysAhead); }
            set { this.Store(x => x.ExpirationWarningDaysAhead, value); }
        }


        public bool LockAccountOnPasswordExpiration {
            get { return this.Retrieve(x => x.LockAccountOnPasswordExpiration); }
            set { this.Store(x => x.LockAccountOnPasswordExpiration, value); }
        }

        public int PasswordAttemptWindow{
            get { return this.Retrieve( x => x.PasswordAttemptWindow);}
            set { this.Store(x => x.PasswordAttemptWindow, value); }
        }


        public bool KeepPasswordHistory{
            get { return this.Retrieve(x => x.KeepPasswordHistory); }
            set { this.Store(x => x.KeepPasswordHistory, value); }
        }

        public bool AllowPreviousPasswords{
            get { return this.Retrieve(x => x.AllowPreviousPasswords); }
            set { this.Store(x => x.AllowPreviousPasswords, value); }
        }

        public int MaxInvalidPasswordAttempts{
            get { return this.Retrieve(x => x.MaxInvalidPasswordAttempts); }
            set { this.Store(x => x.MaxInvalidPasswordAttempts, value); }
        }

    }
}