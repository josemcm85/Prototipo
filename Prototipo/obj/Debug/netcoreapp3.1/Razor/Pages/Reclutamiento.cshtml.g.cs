#pragma checksum "D:\Andres Carpeta\U\diseno conceptual del software\proyectofintech\Prototipo\Pages\Reclutamiento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b329c574435dad0896e2812c644bc788a8c3719"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Prototipo.Pages.Pages_Reclutamiento), @"mvc.1.0.razor-page", @"/Pages/Reclutamiento.cshtml")]
namespace Prototipo.Pages
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
#line 1 "D:\Andres Carpeta\U\diseno conceptual del software\proyectofintech\Prototipo\Pages\_ViewImports.cshtml"
using Prototipo;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b329c574435dad0896e2812c644bc788a8c3719", @"/Pages/Reclutamiento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b387b50e884e560930cab4026cbe6897618240f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Reclutamiento : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Andres Carpeta\U\diseno conceptual del software\proyectofintech\Prototipo\Pages\Reclutamiento.cshtml"
  
    ViewData["Title"] = "RecursosHumanos";
    Layout = "_LayoutRH";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Recursos Humanos</h2>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b329c574435dad0896e2812c644bc788a8c37193392", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <style>
        * {
            box-sizing: border-box;
        }

        .column {
            float: left;
            width: 25%;
            padding: 10px;
            height: 50px;
            margin-right: 50px;
            border: 1px solid black;
        }

        .row:after {
            content: """";
            display: table;
            clear: both;
        }
        .row {
            margin: auto;
            text-align: left;
            width: 1000px;
            
        }
        #buttons {
            float: left;
            width: 200px;
            margin-left: 50px;
            margin-top: 20px;

        }

    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b329c574435dad0896e2812c644bc788a8c37195128", async() => {
                WriteLiteral(@"

    <div id=""wrapper"" class=""row"">
        <div class=""column"" style=""        background-color: #bbb;"">
            <h2>Nombre: </h2>
        </div>
        <div class=""column"" style=""background-color: #bbb;"">
            <h2>Direccion</h2>
        </div>
        <div class=""column"" style=""background-color: #bbb;"">
            <h2>Curriculum</h2>
        </div>
        <div class=""column"" style=""background-color: #ffffff;"">
            <p>andres</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>curridabat</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>ing de software</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Jose</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>pavas</p>
        </div>
        <div class=""column"" style=""        background-color: #ff");
                WriteLiteral(@"ffff;"">
            <p>ing de software</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Daniel</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>curridabat</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>ing de software</p>
        </div>
        <!--columan2-->
        <div class=""column"" style=""background-color: #ffffff;"">
            <p>andres</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>curridabat</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>ing de software</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Jose</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>pavas</p>
        </d");
                WriteLiteral(@"iv>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>ing de software</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Daniel</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>curridabat</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>ing de software</p>
        </div>
        <!--columan3-->
        <div class=""column"" style=""background-color: #ffffff;"">
            <p>luis</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>curridabat</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>ing de alimentos</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Antonio</p>
        </div>
        <div class=""column"" style=""    ");
                WriteLiteral(@"    background-color: #ffffff;"">
            <p>pavas</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>ing mecanica</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Carmen</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>curridabat</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>ing industrial</p>
        </div>
    </div>

    <div id=""buttons"" class=""btn-group"" role=""group""> 
        <div type=""button"" class=""btn btn-primary"">
            Modificar
        </div>
        <div type=""button"" class=""btn btn-primary"">
            Insertar
        </div>
        <div type=""button"" class=""btn btn-primary"">
            Borrar
        </div>
    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Prototipo.Pages.Reclutamiento> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Prototipo.Pages.Reclutamiento> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Prototipo.Pages.Reclutamiento>)PageContext?.ViewData;
        public Prototipo.Pages.Reclutamiento Model => ViewData.Model;
    }
}
#pragma warning restore 1591
