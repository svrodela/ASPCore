#pragma checksum "C:\Users\Sergio\source\repos\ASPCore\ASPCore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "565fce302582daf118b965678ed11dad0dd4f241"
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
#line 1 "C:\Users\Sergio\source\repos\ASPCore\ASPCore\Views\_ViewImports.cshtml"
using ASPCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sergio\source\repos\ASPCore\ASPCore\Views\_ViewImports.cshtml"
using ASPCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"565fce302582daf118b965678ed11dad0dd4f241", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c4ada19fa78fcc822c8d676fe3956dba96f0df0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlumnoModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Sergio\source\repos\ASPCore\ASPCore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Pagina de Alumnos ";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Bienvenido</h1>\r\n\r\n        <br />\r\n        <b> Numero de Control</b> ");
#nullable restore
#line 14 "C:\Users\Sergio\source\repos\ASPCore\ASPCore\Views\Home\Index.cshtml"
                             Write(Model.NC);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        Nombre ");
#nullable restore
#line 16 "C:\Users\Sergio\source\repos\ASPCore\ASPCore\Views\Home\Index.cshtml"
          Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        Apellido Paterno ");
#nullable restore
#line 18 "C:\Users\Sergio\source\repos\ASPCore\ASPCore\Views\Home\Index.cshtml"
                    Write(Model.App);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        Apellido Materno ");
#nullable restore
#line 20 "C:\Users\Sergio\source\repos\ASPCore\ASPCore\Views\Home\Index.cshtml"
                    Write(Model.Apm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        Carrera ");
#nullable restore
#line 22 "C:\Users\Sergio\source\repos\ASPCore\ASPCore\Views\Home\Index.cshtml"
           Write(Model.Carrera);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        Fecha Ingreso ");
#nullable restore
#line 24 "C:\Users\Sergio\source\repos\ASPCore\ASPCore\Views\Home\Index.cshtml"
                 Write(Model.FechaIngreso);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        Promedio ");
#nullable restore
#line 26 "C:\Users\Sergio\source\repos\ASPCore\ASPCore\Views\Home\Index.cshtml"
            Write(Model.Promedio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlumnoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
