#pragma checksum "C:\Users\Janek\source\repos\Calendar\Calendar\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42e0bcbff3244b875d709bd569ce1d3f411e63c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Janek\source\repos\Calendar\Calendar\Views\_ViewImports.cshtml"
using Calendar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Janek\source\repos\Calendar\Calendar\Views\_ViewImports.cshtml"
using Calendar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42e0bcbff3244b875d709bd569ce1d3f411e63c1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"610466001fa29eedf635bb2691bae0e86ed81155", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Calendar.Models.EventsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Janek\source\repos\Calendar\Calendar\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"calendar-box\">\r\n    <div id=\"calendar\"></div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

    document.addEventListener('DOMContentLoaded', function () {
        var calendarEl = document.getElementById('calendar');

        var calendar = new FullCalendar.Calendar(calendarEl, {
            header: {
                left: 'prev, today',
                center: 'title',
                right: 'next'
            },
            events: [
");
#nullable restore
#line 24 "C:\Users\Janek\source\repos\Calendar\Calendar\Views\Home\Index.cshtml"
                 foreach (Event ev in Model.GetAllEvents())
                {
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("{\r\n                    start: \'");
#nullable restore
#line 27 "C:\Users\Janek\source\repos\Calendar\Calendar\Views\Home\Index.cshtml"
                       Write(ev.Date.Date.ToString("yyyy/MM/dd").Replace('.', '-'));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                    end: \'");
#nullable restore
#line 28 "C:\Users\Janek\source\repos\Calendar\Calendar\Views\Home\Index.cshtml"
                     Write(ev.Date.Date.ToString("yyyy/MM/dd").Replace('.', '-'));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                    rendering: \'background\'\r\n                            },");
#nullable restore
#line 30 "C:\Users\Janek\source\repos\Calendar\Calendar\Views\Home\Index.cshtml"
                                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            ],
            dateClick: function (info) {
                window.location.href = '/day/index/' + info.dateStr;
            },
            editable: true,
            eventLimit: true,
            plugins: ['dayGrid', 'interaction']
        });
        calendar.gotoDate('");
#nullable restore
#line 40 "C:\Users\Janek\source\repos\Calendar\Calendar\Views\Home\Index.cshtml"
                      Write(ViewData["CurrDate"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n        calendar.render();\r\n    });\r\n\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Calendar.Models.EventsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591