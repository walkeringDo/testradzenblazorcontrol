#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatTabBar\MatTabBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5dee6a12c194b2515a894d8cd1994a979206fa4"
// <auto-generated/>
#pragma warning disable 1591
namespace MatBlazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class MatTabBar : BaseMatTabBar
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatTabBar\MatTabBar.razor"
             ClassMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatTabBar\MatTabBar.razor"
                                                         StyleMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "role", "tablist");
            __builder.AddMultipleAttributes(4, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatTabBar\MatTabBar.razor"
                                                                                                             Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Id", 
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatTabBar\MatTabBar.razor"
                                                                                                                              Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddElementReferenceCapture(6, (__value) => {
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatTabBar\MatTabBar.razor"
                                           Ref = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "mdc-tab-scroller");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "mdc-tab-scroller__scroll-area");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "mdc-tab-scroller__scroll-content");
            __Blazor.MatBlazor.MatTabBar.TypeInference.CreateCascadingValue_0(__builder, 13, 14, 
#nullable restore
#line 8 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatTabBar\MatTabBar.razor"
                                        this

#line default
#line hidden
#nullable disable
            , 15, (__builder2) => {
                __builder2.AddContent(16, 
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatTabBar\MatTabBar.razor"
                     ChildContent

#line default
#line hidden
#nullable disable
                );
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.MatBlazor.MatTabBar
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
