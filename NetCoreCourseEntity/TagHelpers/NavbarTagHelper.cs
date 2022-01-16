using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreCourseEntity.TagHelpers
{
    [HtmlTargetElement("bs-navbar", Attributes = "toplam-sayfa, aktif-sayfa")]
    public class NavbarTagHelper : TagHelper
    {
        public int AktifSayfa { get; set; }
        public int ToplamSayfa { get; set; }
        public string resim { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.PreContent.SetHtmlContent($@"<nav class=""navbar navbar-expand-lg navbar-light bg-light""><img src=""/Images/{resim}.png"" width=""70"" height=""60"" /> <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
              <span class=""navbar-toggler-icon""></span>
              </button><div class=""collapse navbar-collapse"" id=""navbarNav""><ul class=""navbar-nav"">");

            for (var i = 1; i <= ToplamSayfa; i++)
            {
                output.Content.AppendHtml($@"<li class=""nav-item {(i == AktifSayfa ? "active" : "")}""><a class=""nav-link"" href=""Menu-{i}"" title=""Sayfaya Git {i}"">Menü-{i}</a></li>");
                //< li class="nav-item active"><a class="nav-link" href="#">Menu-1</a></li>
            }
            output.PostElement.SetHtmlContent("</ul></div></nav>");
            output.Attributes.Clear();
        }
    }
}
