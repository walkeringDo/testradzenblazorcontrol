#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatFAB\MatFAB.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e6f79f36a60f7471195a04b73496b686f4e6265"
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
    public partial class MatFAB : BaseMatFAB
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatFAB\MatFAB.razor"
                ClassMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatFAB\MatFAB.razor"
                                                StyleMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatFAB\MatFAB.razor"
                                                                                  OnClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMultipleAttributes(4, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatFAB\MatFAB.razor"
                                                                                                                    Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Id", 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatFAB\MatFAB.razor"
                                                                                                                                     Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddElementReferenceCapture(6, (__value) => {
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatFAB\MatFAB.razor"
                                                                                                 Ref = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(7, 
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatFAB\MatFAB.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatFAB\MatFAB.razor"
     if (Icon != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "span");
            __builder.AddAttribute(9, "class", "mdc-fab__icon material-icons");
            __builder.AddContent(10, 
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatFAB\MatFAB.razor"
                                                    Icon

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 10 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatFAB\MatFAB.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatFAB\MatFAB.razor"
     if (Label != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "span");
            __builder.AddAttribute(12, "class", "mdc-fab__label");
            __builder.AddContent(13, 
#nullable restore
#line 13 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatFAB\MatFAB.razor"
                                      Label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 14 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatFAB\MatFAB.razor"
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
