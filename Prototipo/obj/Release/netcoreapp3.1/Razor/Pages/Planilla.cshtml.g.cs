#pragma checksum "C:\Users\josem\Desktop\Prototipo Diseno\Prototipo\Prototipo\Pages\Planilla.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b84fffa4f76999d4ae3a664c51e4e033583b3d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Prototipo.Pages.Pages_Planilla), @"mvc.1.0.razor-page", @"/Pages/Planilla.cshtml")]
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
#line 1 "C:\Users\josem\Desktop\Prototipo Diseno\Prototipo\Prototipo\Pages\_ViewImports.cshtml"
using Prototipo;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b84fffa4f76999d4ae3a664c51e4e033583b3d3", @"/Pages/Planilla.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b387b50e884e560930cab4026cbe6897618240f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Planilla : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\josem\Desktop\Prototipo Diseno\Prototipo\Prototipo\Pages\Planilla.cshtml"
  
    ViewData["Title"] = "Planilla";
    Layout = "_LayoutRH";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Planilla</h1>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b84fffa4f76999d4ae3a664c51e4e033583b3d33292", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <style>
        * {
            box-sizing: border-box;
        }

        .column {
            float: left;
            width: 25%;
            width: 190px;
            height: 50px;
            margin-right: 10px;
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
            width: 1100px;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b84fffa4f76999d4ae3a664c51e4e033583b3d35013", async() => {
                WriteLiteral(@"

    <div class=""row"">
        <div class=""column"" style=""background-color: #bbb;"">
            <h3>Nombre: </h3>
        </div>
        <div class=""column"" style=""background-color: #bbb;"">
            <h3>Direccion</h3>
        </div>
        <div class=""column"" style=""background-color: #bbb;"">
            <h3>Curriculum</h3>
        </div>
        <div class=""column"" style=""background-color: #bbb;"">
            <h3>Departamento</h3>
        </div>
        <div class=""column"" style=""background-color: #bbb;"">
            <h3>Salario</h3>
        </div>

        <!--columna-->
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Jose</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Pavas</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>ing de software</p>
        </div>
        <div class=""column"" style=""        background-color: #ffff");
                WriteLiteral(@"ff;"">
            <p>Soporte Tecnico</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>$100.000.000</p>
        </div>
        <!--columna-->
        <!--columna-->
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Daniel</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>pinares</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>ing de software</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Soporte Tecnico</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>$100.000.000</p>
        </div>
        <!--columna-->
        <!--columna-->
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Fabricio</p>
        </div>
        <div class=""colu");
                WriteLiteral(@"mn"" style=""        background-color: #ffffff;"">
            <p>escazu</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>ing de software</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Soporte Tecnico</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>$100.000.000</p>
        </div>
        <!--columna-->
        <!--columna-->
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Antonio</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>puntarenas</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>ing de software</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Soporte Tecnico</p>
        </div>
        <div class=""colum");
                WriteLiteral(@"n"" style=""        background-color: #ffffff;"">
            <p>$100.000.000</p>
        </div>
        <!--columna-->
        <!--columna-->
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Carmen</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Alajuela</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>ing de software</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Soporte Tecnico</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>$100.000.000</p>
        </div>
        <!--columna-->
        <!--columna-->
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Randall</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Desamparados</p>
  ");
                WriteLiteral(@"      </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>ing de software</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>Soporte Tecnico</p>
        </div>
        <div class=""column"" style=""        background-color: #ffffff;"">
            <p>$100.000.000</p>
        </div>
        <!--columna-->

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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Prototipo.Pages.PlanillaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Prototipo.Pages.PlanillaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Prototipo.Pages.PlanillaModel>)PageContext?.ViewData;
        public Prototipo.Pages.PlanillaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
