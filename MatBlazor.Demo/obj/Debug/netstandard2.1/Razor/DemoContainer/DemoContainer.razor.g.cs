#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\DemoContainer\DemoContainer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "427e1fbaafc5919a1363867e2db7ed5427bd2f02"
// <auto-generated/>
#pragma warning disable 1591
namespace MatBlazor.Demo.DemoContainer
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using MatBlazor.Demo.BlazorFiddle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using MatBlazor.Demo.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using MatBlazor.Demo.Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using MatBlazor.Demo.DemoContainer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using MatBlazor.Demo.Doc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using MatBlazor.Demo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using MatBlazor.Demo.Frames;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using MatBlazor.Demo.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\DemoContainer\DemoContainer.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    public partial class DemoContainer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\DemoContainer\DemoContainer.razor"
 if (Header != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MatBlazor.MatH5>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, 
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\DemoContainer\DemoContainer.razor"
            Header

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 8 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\DemoContainer\DemoContainer.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "display: flex; flex-direction: column; padding: 10px;");
            __builder.AddAttribute(5, "class", "mat-elevation-z5 mdc-theme--surface");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "style", "padding: 5px; border: 1px solid white;");
            __builder.AddAttribute(8, "class", 
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\DemoContainer\DemoContainer.razor"
                                                                Class

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, 
#nullable restore
#line 12 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\DemoContainer\DemoContainer.razor"
         Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "style", "padding: 5px; font-family: monospace; overflow: auto;");
            __builder.OpenElement(13, "div");
            __builder.AddContent(14, 
#nullable restore
#line 16 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\DemoContainer\DemoContainer.razor"
             SourceContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n    ");
            __builder.AddMarkupContent(16, "<div style=\"overflow: hidden; padding-top: 5px;\"><ins class=\"adsbygoogle\" style=\"display:block; text-align:center;\" data-ad-layout=\"in-article\" data-ad-format=\"fluid\" data-ad-client=\"ca-pub-3904134905954949\" data-ad-slot=\"7908819923\"></ins></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\DemoContainer\DemoContainer.razor"
 

    [Parameter]
    public string Class { get; set; }

    [Parameter]
    public string Header { get; set; }

    [Parameter]
    public RenderFragment Content { get; set; }

    [Parameter]
    public RenderFragment SourceContent { get; set; }

    [Parameter]
    public string SourcePath { get; set; }

    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);
        if (firstRender)
        {
            JsRuntime.InvokeAsync<object>("matBlazorDemo.initAd");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591