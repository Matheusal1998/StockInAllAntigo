using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace StockInAll.App.Extensions
{
    [HtmlTargetElement("*", Attributes = "disable-by-claim-name")]
    [HtmlTargetElement("*", Attributes = "disable-by-claim-value")]
    public class ApagarElementoMenuByClaim : TagHelper
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public ApagarElementoMenuByClaim(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor; 
        }

        [HtmlAttributeName("disable-by-claim-name")]
        public string IdentityClaimName { get; set; }

        [HtmlAttributeName("disable-by-claim-value")]
        public string IdentityClaimValue { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (context == null)
                throw new ArgumentException(nameof(context));

            if (output == null)
                throw new ArgumentException(nameof(output));

            var temAcesso = CustomAuthorization.ValidarClaimsUsuario(_contextAccessor.HttpContext, IdentityClaimName, IdentityClaimValue);

            if (temAcesso) return;

            output.SuppressOutput();
        }
    }
}
