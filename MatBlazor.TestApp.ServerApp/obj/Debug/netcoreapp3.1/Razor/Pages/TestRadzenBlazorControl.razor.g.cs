#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\Pages\TestRadzenBlazorControl.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "393191bb013088f8eaa504d4dfc3c464c60f6b6b"
// <auto-generated/>
#pragma warning disable 1591
namespace MatBlazor.TestApp.ServerApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using MatBlazor.TestApp.ServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using MatBlazor.TestApp.ServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using MatBlazor.TestApp.ServerApp.TestMetaComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using MatBlazor.TestApp.ServerApp.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Container;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Button;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Dom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Dynamic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.NavMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Input;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Radio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Select;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.CheckBox;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Switch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Table;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Popup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Pagination;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Form;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/testradzenblazorcontrol")]
    public partial class TestRadzenBlazorControl : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>TestRadzenBlazorControl</h3>\r\n\r\n");
            __Blazor.MatBlazor.TestApp.ServerApp.Pages.TestRadzenBlazorControl.TypeInference.CreateMatSelect_0(__builder, 1, 2, "Pick a Food Group", 3, 
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\Pages\TestRadzenBlazorControl.razor"
                                                   intValue

#line default
#line hidden
#nullable disable
            , 4, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => intValue = __value, intValue)), 5, () => intValue, 6, (__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatOption<int>>(7);
                __builder2.AddAttribute(8, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\Pages\TestRadzenBlazorControl.razor"
                                   0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(10, "Pie");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatOption<int>>(12);
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\Pages\TestRadzenBlazorControl.razor"
                                   1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(15, "Line");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatOption<int>>(17);
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\Pages\TestRadzenBlazorControl.razor"
                                   2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(20, "bar");
                }
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(21, "\r\n\r\n<p></p>\r\n");
            __builder.OpenComponent<MatBlazor.TestApp.ServerApp.Pages.ButtonRadzen>(22);
            __builder.AddAttribute(23, "textName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\Pages\TestRadzenBlazorControl.razor"
                         textname

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n<p></p>\r\n");
            __builder.OpenComponent<MatBlazor.TestApp.ServerApp.Shared.MatControlTest>(25);
            __builder.AddAttribute(26, "iconText", "sync");
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n\r\n<p></p>\r\n");
            __builder.OpenComponent<MatBlazor.TestApp.ServerApp.Pages.Line_Chart>(28);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\Pages\TestRadzenBlazorControl.razor"
 
    public string textname { get; set; } = "TestBtton";
    public int intValue { get; set; }

   

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.MatBlazor.TestApp.ServerApp.Pages.TestRadzenBlazorControl
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591