#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatDivider.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63e5c4e29235d2fc5e425c21c137943dbad6a33d"
// <auto-generated/>
#pragma warning disable 1591
namespace MatBlazor.Demo.Demo
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
    public partial class DemoMatDivider : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.Demo.Doc.DocMatDivider>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n\n");
            __builder.AddMarkupContent(2, "<h5 class=\"mat-h5\">Example</h5>\n\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(3);
            __builder.AddAttribute(4, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<h3 class=\"mat-subtitle1\">Simple</h3>\n\n        ");
                __builder2.OpenComponent<MatBlazor.MatListItem>(6);
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(8, "Item 1");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatDivider>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatListItem>(12);
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(14, "Item 2");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatDivider>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatListItem>(18);
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(20, "Item 3");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\n\n        ");
                __builder2.AddMarkupContent(22, "<h3 class=\"mat-subtitle1\">Inset</h3>\n\n        ");
                __builder2.OpenComponent<MatBlazor.MatListItem>(23);
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(25, "Item 1");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatDivider>(27);
                __builder2.AddAttribute(28, "Inset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatDivider.razor"
                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatListItem>(30);
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(32, "Item 2");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatDivider>(34);
                __builder2.AddAttribute(35, "Inset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatDivider.razor"
                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatListItem>(37);
                __builder2.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(39, "Item 3");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\n\n        ");
                __builder2.AddMarkupContent(41, "<h3 class=\"mat-subtitle1\">Padded</h3>\n\n        ");
                __builder2.OpenComponent<MatBlazor.MatListItem>(42);
                __builder2.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(44, "Item 1");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatDivider>(46);
                __builder2.AddAttribute(47, "Padded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatDivider.razor"
                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatListItem>(49);
                __builder2.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(51, "Item 2");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatDivider>(53);
                __builder2.AddAttribute(54, "Padded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatDivider.razor"
                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatListItem>(56);
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(58, "Item 3");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(59, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(60);
                __builder2.AddAttribute(61, "Template", "MatBlazor");
                __builder2.AddAttribute(62, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatDivider.razor"
                                                  @"
        <h3 class=""mat-subtitle1"">Simple</h3>

        <MatListItem>Item 1</MatListItem>
        <MatDivider></MatDivider>
        <MatListItem>Item 2</MatListItem>
        <MatDivider></MatDivider>
        <MatListItem>Item 3</MatListItem>

        <h3 class=""mat-subtitle1"">Inset</h3>

        <MatListItem>Item 1</MatListItem>
        <MatDivider Inset=""true""></MatDivider>
        <MatListItem>Item 2</MatListItem>
        <MatDivider Inset=""true""></MatDivider>
        <MatListItem>Item 3</MatListItem>

        <h3 class=""mat-subtitle1"">Padded</h3>

        <MatListItem>Item 1</MatListItem>
        <MatDivider Padded=""true""></MatDivider>
        <MatListItem>Item 2</MatListItem>
        <MatDivider Padded=""true""></MatDivider>
        <MatListItem>Item 3</MatListItem>
    "

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
