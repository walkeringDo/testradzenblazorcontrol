#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDrawer\MatDrawer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cba72551270fac898c680bf70092f4c3c5a7ebe9"
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
    public partial class MatDrawer : BaseMatDrawer
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "aside");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDrawer\MatDrawer.razor"
               ClassMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDrawer\MatDrawer.razor"
                                               StyleMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMultipleAttributes(3, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDrawer\MatDrawer.razor"
                                                                                                Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Id", 
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDrawer\MatDrawer.razor"
                                                                                                                 Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddElementReferenceCapture(5, (__value) => {
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDrawer\MatDrawer.razor"
                                                                             Ref = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "mdc-drawer__content");
            __builder.AddAttribute(8, "tabindex", 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDrawer\MatDrawer.razor"
                                                ContentTabIndex

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, 
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDrawer\MatDrawer.razor"
         ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 10 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDrawer\MatDrawer.razor"
 if (Mode == MatDrawerMode.Modal)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<div class=\"mdc-drawer-scrim\"></div>");
#nullable restore
#line 13 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDrawer\MatDrawer.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591