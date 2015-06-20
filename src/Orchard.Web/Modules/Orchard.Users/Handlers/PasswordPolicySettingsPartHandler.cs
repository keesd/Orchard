using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Localization;
using Orchard.Users.Models;

namespace Orchard.Users.Handlers {
    public class PasswordPolicySettingsPartHandler : ContentHandler {
        public PasswordPolicySettingsPartHandler()
        {
            T = NullLocalizer.Instance;
            Filters.Add(new ActivatingFilter<PasswordPolicySettingsPart>("Site"));
            Filters.Add(new TemplateFilterForPart<PasswordPolicySettingsPart>("PasswordPolicySettings", "Parts/Users.PasswordPolicySettings", "Passwords"));
        }

        public Localizer T { get; set; }

        protected override void GetItemMetadata(GetContentItemMetadataContext context) {
            if (context.ContentItem.ContentType != "Site")
                return;
            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T("Passwords")));
        }
    }
}