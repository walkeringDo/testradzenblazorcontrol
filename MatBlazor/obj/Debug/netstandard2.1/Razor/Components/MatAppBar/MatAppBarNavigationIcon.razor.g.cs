#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatAppBar\MatAppBarNavigationIcon.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9efc8fea8fa3815bb791442c1ff6ed9b483e49b"
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
    public partial class MatAppBarNavigationIcon : BaseMatDomComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "a");
            __builder.AddAttribute(1, "class", (
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatAppBar\MatAppBarNavigationIcon.razor"
           ClassMapper.AsString()

#line default
#line hidden
#nullable disable
            ) + " material-icons" + " mdc-top-app-bar__navigation-icon");
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatAppBar\MatAppBarNavigationIcon.razor"
                                                                                           StyleMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMultipleAttributes(3, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatAppBar\MatAppBarNavigationIcon.razor"
                                                                                                                                           Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Id", 
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatAppBar\MatAppBarNavigationIcon.razor"
                                                                                                                                                            Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatAppBar\MatAppBarNavigationIcon.razor"
                                                                                                                                                                          OnClickHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(6, (__value) => {
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatAppBar\MatAppBarNavigationIcon.razor"
                                                                                                                         Ref = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(7, "menu");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591