#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlider\MatSlider.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3e41b88093a4244b90481969428fce26ea4d0a4"
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
    public partial class MatSlider<TValue> : BaseMatSlider<TValue>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlider\MatSlider.razor"
                        ClassMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlider\MatSlider.razor"
                                                        StyleMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "tabindex", "0");
            __builder.AddAttribute(4, "role", "slider");
            __builder.AddAttribute(5, "aria-valuemin", 
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlider\MatSlider.razor"
                     ValueMin

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "aria-valuemax", 
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlider\MatSlider.razor"
                                               ValueMax

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "aria-valuenow", 
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlider\MatSlider.razor"
                                                                         Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "data-step", 
#nullable restore
#line 8 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlider\MatSlider.razor"
                  EnableStep ? Step?.ToString() : null

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "aria-label", 
#nullable restore
#line 8 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlider\MatSlider.razor"
                                                                      Label

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "aria-disabled", 
#nullable restore
#line 8 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlider\MatSlider.razor"
                                                                                             Disabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddMultipleAttributes(11, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlider\MatSlider.razor"
                  Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Id", 
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlider\MatSlider.razor"
                                   Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddElementReferenceCapture(13, (__value) => {
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlider\MatSlider.razor"
           Ref = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "mdc-slider__track-container");
            __builder.AddMarkupContent(16, "<div class=\"mdc-slider__track\"></div>");
#nullable restore
#line 12 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlider\MatSlider.razor"
         if (Discrete && Markers)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "mdc-slider__track-marker-container");
            __builder.AddAttribute(19, "style", 
#nullable restore
#line 15 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlider\MatSlider.razor"
                         MarkerStyle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 17 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlider\MatSlider.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "mdc-slider__thumb-container");
#nullable restore
#line 21 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlider\MatSlider.razor"
         if (Pin)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "mdc-slider__pin");
            __builder.OpenElement(25, "span");
            __builder.AddAttribute(26, "class", "mdc-slider__pin-value-marker");
            __builder.AddContent(27, 
#nullable restore
#line 24 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlider\MatSlider.razor"
                                                            Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 26 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSlider\MatSlider.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "<svg class=\"mdc-slider__thumb\" width=\"21\" height=\"21\"><circle cx=\"10.5\" cy=\"10.5\" r=\"7.875\"></circle></svg>\n        <div class=\"mdc-slider__focus-ring\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
