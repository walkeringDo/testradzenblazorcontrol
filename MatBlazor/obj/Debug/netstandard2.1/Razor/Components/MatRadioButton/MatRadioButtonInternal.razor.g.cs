#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioButtonInternal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e925ea38a5bdb5c5486bf2eac4daaae11795840"
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
    public partial class MatRadioButtonInternal<TValue> : BaseMatRadioButtonInternal<TValue>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "mdc-form-field");
            __builder.AddElementReferenceCapture(2, (__value) => {
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioButtonInternal.razor"
                                  FormFieldRef = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", 
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioButtonInternal.razor"
                 ClassMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "style", 
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioButtonInternal.razor"
                                                 StyleMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddElementReferenceCapture(6, (__value) => {
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioButtonInternal.razor"
                                                                               Ref = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "class", "mdc-radio__native-control");
            __builder.AddAttribute(9, "type", "radio");
            __builder.AddAttribute(10, "name", 
#nullable restore
#line 8 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioButtonInternal.razor"
                                                                     Group.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "checked", 
#nullable restore
#line 8 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioButtonInternal.razor"
                                                                                         Checked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "value", 
#nullable restore
#line 8 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioButtonInternal.razor"
                                                                                                          ValueAsString

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioButtonInternal.razor"
                          ((e) => OnChangeHandler(e))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "id", 
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioButtonInternal.razor"
                                                            Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "disabled", 
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioButtonInternal.razor"
                                                                          Disabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddMultipleAttributes(16, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioButtonInternal.razor"
                                                                                                Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n        ");
            __builder.AddMarkupContent(18, "<div class=\"mdc-radio__background\"><div class=\"mdc-radio__outer-circle\"></div>\n            <div class=\"mdc-radio__inner-circle\"></div></div>");
            __builder.CloseElement();
#nullable restore
#line 15 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioButtonInternal.razor"
     if (Label != null ||@ChildContent!=null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "label");
            __builder.AddAttribute(20, "for", 
#nullable restore
#line 17 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioButtonInternal.razor"
                     Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, 
#nullable restore
#line 17 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioButtonInternal.razor"
                          Label

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, 
#nullable restore
#line 17 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioButtonInternal.razor"
                                ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 18 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioButtonInternal.razor"
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