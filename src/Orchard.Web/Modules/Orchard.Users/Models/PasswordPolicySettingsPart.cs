using Orchard.ContentManagement;

namespace Orchard.Users.Models {
    public class PasswordPolicySettingsPart : ContentPart {
        public bool Enabled {
            get { return this.Retrieve(x => x.Enabled); }
            set { this.Store(x => x.Enabled, value); }
        }

        public int MinPasswordLength {
            get { return this.Retrieve(x => x.MinPasswordLength); }
            set { this.Store(x => x.MinPasswordLength, value); }
        }

        public int MinNonAlphaNummericChars {
            get { return this.Retrieve(x => x.MinNonAlphaNummericChars); }
            set { this.Store(x => x.MinNonAlphaNummericChars, value); }
        }
        
        public int MinNummericChars {
            get { return this.Retrieve(x => x.MinNummericChars); }
            set { this.Store(x => x.MinNummericChars, value); }
        }

        public int MinLowerCaseChars {
            get { return this.Retrieve(x => x.MinLowerCaseChars); }
            set { this.Store(x => x.MinLowerCaseChars, value); }
        }

        public int MinUpperCaseChars {
            get { return this.Retrieve(x => x.MinUpperCaseChars); }
            set { this.Store(x => x.MinUpperCaseChars, value); }
        }

        public bool AdminMustResetExpiredPassword {
            get { return this.Retrieve(x => x.AdminMustResetExpiredPassword); }
            set { this.Store(x => x.AdminMustResetExpiredPassword, value); }
        }

        public bool KeepPasswordHistory
        {
            get { return this.Retrieve(x => x.KeepPasswordHistory); }
            set { this.Store(x => x.KeepPasswordHistory, value); }
        }

        public bool AllowPreviousPasswords
        {
            get { return this.Retrieve(x => x.AllowPreviousPasswords); }
            set { this.Store(x => x.AllowPreviousPasswords, value); }
        }

        public int MaxLoginAttemptsBeforeLock
        {
            get { return this.Retrieve(x => x.MaxLoginAttemptsBeforeLock); }
            set { this.Store(x => x.MaxLoginAttemptsBeforeLock, value); }
        }

        public bool EnableLostPassword {
            get { return this.Retrieve(x => x.EnableLostPassword); }
            set { this.Store(x => x.EnableLostPassword, value); }
        }

    }
}