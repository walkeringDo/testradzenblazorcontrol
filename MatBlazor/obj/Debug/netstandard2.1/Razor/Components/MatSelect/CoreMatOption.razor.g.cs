#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatOption.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67c079e5a94978d4ec7f72efc1812041b3772bf7"
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
    public partial class CoreMatOption<TValue> : BaseCoreMatOption<TValue>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "li");
            __builder.AddAttribute(1, "data-value", 
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatOption.razor"
                 StringValue()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "class", 
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatOption.razor"
                                        ClassMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "style", 
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatOption.razor"
                                                                        StyleMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMultipleAttributes(4, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatOption.razor"
                                                                                                                        Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Id", 
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatOption.razor"
                                                                                                                                         Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "aria-disabled", 
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatOption.razor"
                                                                                                                                                             RenderAttributeAriaDisabled()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "role", "option");
            __builder.AddElementReferenceCapture(8, (__value) => {
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatOption.razor"
                                                                                                      Ref = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(9, "<span class=\"mdc-list-item__ripple\"></span>\n    ");
            __builder.OpenElement(10, "span");
            __builder.AddAttribute(11, "class", "mdc-list-item__text");
            __builder.AddContent(12, 
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatOption.razor"
         ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
