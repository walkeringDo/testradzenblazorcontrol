#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlideToggle\MatSlideToggle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3810a93c0b06f03df36899d14735af2bc7a18a8"
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
    public partial class MatSlideToggle<TValue> : BaseMatSlideToggle<TValue>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlideToggle\MatSlideToggle.razor"
             ClassMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlideToggle\MatSlideToggle.razor"
                                             StyleMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMultipleAttributes(3, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlideToggle\MatSlideToggle.razor"
                                                                                              Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Id", 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlideToggle\MatSlideToggle.razor"
                                                                                                               Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddElementReferenceCapture(5, (__value) => {
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlideToggle\MatSlideToggle.razor"
                                                                           Ref = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(6, "<div class=\"mdc-switch__track\"></div>\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "mdc-switch__thumb-underlay");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "mdc-switch__thumb");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "checkbox");
            __builder.AddAttribute(13, "id", 
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlideToggle\MatSlideToggle.razor"
                                        Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "class", "mdc-switch__native-control");
            __builder.AddAttribute(15, "role", "switch");
            __builder.AddAttribute(16, "checked", 
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlideToggle\MatSlideToggle.razor"
                                                                                                       Checked

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlideToggle\MatSlideToggle.razor"
                                                                                                                           OnChangedHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "disabled", 
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlideToggle\MatSlideToggle.razor"
                                                                                                                                                        Disabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddElementReferenceCapture(19, (__value) => {
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlideToggle\MatSlideToggle.razor"
                                                                                                                                                                         InputRef = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 13 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlideToggle\MatSlideToggle.razor"
 if (Label != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "label");
            __builder.AddAttribute(21, "for", 
#nullable restore
#line 15 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlideToggle\MatSlideToggle.razor"
                 Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, 
#nullable restore
#line 15 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlideToggle\MatSlideToggle.razor"
                      Label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 16 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlideToggle\MatSlideToggle.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
