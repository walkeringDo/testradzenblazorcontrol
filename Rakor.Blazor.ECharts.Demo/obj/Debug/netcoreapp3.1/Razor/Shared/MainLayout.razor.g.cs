#pragma checksum "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbc8d2383c76a5c9c7b72e4779dd312d63a157d6"
// <auto-generated/>
#pragma warning disable 1591
namespace Demo.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazui.Component.Popup.BPopup>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "blaz-layout");
            __builder.AddAttribute(4, "style", "flex:1");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "blaz-layout-container");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "blaz-layout-west blaz-layout-card");
            __builder.OpenComponent<Demo.Shared.NavMenu>(9);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "blaz-layout-center blaz-layout-card");
            __builder.AddContent(13, 
#nullable restore
#line 9 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
