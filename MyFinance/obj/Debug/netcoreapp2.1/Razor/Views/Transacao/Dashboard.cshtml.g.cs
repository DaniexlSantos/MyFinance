#pragma checksum "C:\Users\helle\source\repos\MyFinance\MyFinance\Views\Transacao\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07ef28f0d2c6c0f8ab145c335319b4556245c7e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transacao_Dashboard), @"mvc.1.0.view", @"/Views/Transacao/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transacao/Dashboard.cshtml", typeof(AspNetCore.Views_Transacao_Dashboard))]
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
#line 1 "C:\Users\helle\source\repos\MyFinance\MyFinance\Views\_ViewImports.cshtml"
using MyFinance;

#line default
#line hidden
#line 2 "C:\Users\helle\source\repos\MyFinance\MyFinance\Views\_ViewImports.cshtml"
using MyFinance.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07ef28f0d2c6c0f8ab145c335319b4556245c7e1", @"/Views/Transacao/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d05dd6abef5a8ff60f9a555c67ee727241a6c480", @"/Views/_ViewImports.cshtml")]
    public class Views_Transacao_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 425, true);
            WriteLiteral(@"<h3> Meu Dashboard </h3>

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.2/Chart.bundle.min.js""></script>

    <div id=""canvas-holder"" style=""width:75%"">
        <canvas id=""chart-area""></canvas>
    </div>    
    <script>
		var randomScalingFactor = function() {
			return Math.round(Math.random() * 100);
		};

		var config = {
			type: 'pie',
			data: {
				datasets: [{
					data: [");
            EndContext();
            BeginContext(426, 25, false);
#line 17 "C:\Users\helle\source\repos\MyFinance\MyFinance\Views\Transacao\Dashboard.cshtml"
                      Write(Html.Raw(ViewBag.Valores));

#line default
#line hidden
            EndContext();
            BeginContext(451, 27, true);
            WriteLiteral("],\r\n\t\t\t\t\tbackgroundColor: [");
            EndContext();
            BeginContext(479, 23, false);
#line 18 "C:\Users\helle\source\repos\MyFinance\MyFinance\Views\Transacao\Dashboard.cshtml"
                                 Write(Html.Raw(ViewBag.Cores));

#line default
#line hidden
            EndContext();
            BeginContext(502, 51, true);
            WriteLiteral("],\r\n\t\t\t\t\tlabel: \'Dataset 1\'\r\n\t\t\t\t}],\r\n\t\t\t\tlabels: [");
            EndContext();
            BeginContext(554, 24, false);
#line 21 "C:\Users\helle\source\repos\MyFinance\MyFinance\Views\Transacao\Dashboard.cshtml"
                    Write(Html.Raw(ViewBag.Labels));

#line default
#line hidden
            EndContext();
            BeginContext(578, 228, true);
            WriteLiteral("]\r\n\t\t\t},\r\n\t\t\toptions: {\r\n\t\t\t\tresponsive: true\r\n\t\t\t}\r\n\t\t};\r\n\r\n\t\twindow.onload = function() {\r\n\t\t\tvar ctx = document.getElementById(\'chart-area\').getContext(\'2d\');\r\n\t\t\twindow.myPie = new Chart(ctx, config);\r\n\t\t};\t\r\n    </script>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
