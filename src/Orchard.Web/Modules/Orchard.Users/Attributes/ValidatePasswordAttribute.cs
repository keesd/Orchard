using Orchard.Users.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orchard.Users.Attributes
{
    public class ValidatePasswordAttribute : ValidationAttribute, IClientValidatable
    {
        //var passwordPolicySettings = _orchardServices.WorkContext.CurrentSite.As<PasswordPolicySettingsPart>();

        public override bool IsValid(object value)
        {
            return true;   
        }

        public IEnumerable<System.Web.Mvc.ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            throw new NotImplementedException();
        }
    }
}