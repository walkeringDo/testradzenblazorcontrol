#pragma checksum "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Pages\Error.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57ba05f2003e63df4d3329dc584b6e2b9f8a374e"
// <auto-generated/>
#pragma warning disable 1591
namespace Demo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Demo.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Demo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Container;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Button;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Dom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Dynamic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.NavMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Input;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Radio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Select;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.CheckBox;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Switch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Table;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Popup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Pagination;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Form;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Rakor.Blazor.ECharts.Component;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/error")]
    public partial class Error : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-danger\">Error.</h1>\n");
            __builder.AddMarkupContent(1, "<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\n\n");
            __builder.AddMarkupContent(2, "<h3>Development Mode</h3>\n");
            __builder.AddMarkupContent(3, "<p>\n    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.\n</p>\n");
            __builder.AddMarkupContent(4, @"<p><strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
