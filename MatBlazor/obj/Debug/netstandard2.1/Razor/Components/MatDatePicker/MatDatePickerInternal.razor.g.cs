#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDatePicker\MatDatePickerInternal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffab807f2ee4d57fa91af7f59b41831d76bd4c1b"
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
    public partial class MatDatePickerInternal<TValue> : BaseMatDatePickerInternal<TValue>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddContent(0, 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDatePicker\MatDatePickerInternal.razor"
 base.BuildRenderTree

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDatePicker\MatDatePickerInternal.razor"
 

    protected override RenderFragment BuildRenderTreeChildContent()
    {
        return (builder) =>
        {
            builder.AddContent(0, base.BuildRenderTreeChildContent());
            if (!DisableCalendar)
            {
                builder.AddContent(1, 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(1, "div");
            __builder2.AddAttribute(2, "class", "mat-text-field-actions-container");
            __builder2.OpenElement(3, "input");
            __builder2.AddAttribute(4, "style", "display: none;");
            __builder2.AddElementReferenceCapture(5, (__value) => {
#nullable restore
#line 18 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDatePicker\MatDatePickerInternal.razor"
                                                       flatpickrInputRef = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder2.CloseElement();
            __builder2.AddMarkupContent(6, "\n                                          ");
            __builder2.OpenComponent<MatBlazor.MatIconButton>(7);
            __builder2.AddAttribute(8, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDatePicker\MatDatePickerInternal.razor"
                                                                MatIconNames.Calendar_today

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddAttribute(9, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDatePicker\MatDatePickerInternal.razor"
                                                                                                      OnClickIconHandler

#line default
#line hidden
#nullable disable
            )));
            __builder2.CloseComponent();
            __builder2.CloseElement();
        }
#nullable restore
#line 20 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDatePicker\MatDatePickerInternal.razor"
                                            );
            }
        };
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591