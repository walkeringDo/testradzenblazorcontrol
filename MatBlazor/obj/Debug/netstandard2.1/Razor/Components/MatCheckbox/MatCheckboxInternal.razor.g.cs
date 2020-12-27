#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatCheckbox\MatCheckboxInternal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "670b92992ac10115f8909e7d9bc8c9709f4c4726"
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
    public partial class MatCheckboxInternal<TValue> : BaseMatCheckboxInternal<TValue>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatCheckbox\MatCheckboxInternal.razor"
             ClassMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatCheckbox\MatCheckboxInternal.razor"
                                             StyleMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMultipleAttributes(3, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatCheckbox\MatCheckboxInternal.razor"
                                                                                              Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(4, (__value) => {
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatCheckbox\MatCheckboxInternal.razor"
                                                                           Ref = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "mdc-checkbox");
            __builder.AddElementReferenceCapture(7, (__value) => {
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatCheckbox\MatCheckboxInternal.razor"
                                    ComponentRef = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "checkbox");
            __builder.AddAttribute(10, "class", "mdc-checkbox__native-control");
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 10 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatCheckbox\MatCheckboxInternal.razor"
                          ChangeHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "checked", 
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatCheckbox\MatCheckboxInternal.razor"
                         CurrentValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "disabled", 
#nullable restore
#line 12 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatCheckbox\MatCheckboxInternal.razor"
                         Disabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "value", 
#nullable restore
#line 13 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatCheckbox\MatCheckboxInternal.razor"
                       InputValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "id", 
#nullable restore
#line 14 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatCheckbox\MatCheckboxInternal.razor"
                     Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddMultipleAttributes(16, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 15 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatCheckbox\MatCheckboxInternal.razor"
                             GetInputAttributes()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(17, (__value) => {
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatCheckbox\MatCheckboxInternal.razor"
                      InputRef = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n\n        ");
            __builder.AddMarkupContent(19, @"<div class=""mdc-checkbox__background""><svg class=""mdc-checkbox__checkmark"" viewBox=""0 0 24 24""><path class=""mdc-checkbox__checkmark-path"" fill=""none"" d=""M1.73,12.91 8.1,19.28 22.79,4.59""></path></svg>
            <div class=""mdc-checkbox__mixedmark""></div></div>");
            __builder.CloseElement();
#nullable restore
#line 28 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatCheckbox\MatCheckboxInternal.razor"
     if (Label != null || ChildContent != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "label");
            __builder.AddAttribute(21, "for", 
#nullable restore
#line 30 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatCheckbox\MatCheckboxInternal.razor"
                     Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, 
#nullable restore
#line 30 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatCheckbox\MatCheckboxInternal.razor"
                          Label

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, 
#nullable restore
#line 30 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatCheckbox\MatCheckboxInternal.razor"
                                ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 31 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatCheckbox\MatCheckboxInternal.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591