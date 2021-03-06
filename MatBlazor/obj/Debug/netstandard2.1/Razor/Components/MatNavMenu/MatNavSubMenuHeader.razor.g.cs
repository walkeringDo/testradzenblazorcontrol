#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatNavMenu\MatNavSubMenuHeader.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74f9eb907d08fdd5577c15e5de95c913189040c3"
// <auto-generated/>
#pragma warning disable 1591
namespace MatBlazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatNavMenu\MatNavSubMenuHeader.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    public partial class MatNavSubMenuHeader : BaseMatDomComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatNavMenu\MatNavSubMenuHeader.razor"
             ClassMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatNavMenu\MatNavSubMenuHeader.razor"
                                                         StyleMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatNavMenu\MatNavSubMenuHeader.razor"
                                                                                           OnClickHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMultipleAttributes(4, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatNavMenu\MatNavSubMenuHeader.razor"
                                                                                                                        Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Id", 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatNavMenu\MatNavSubMenuHeader.razor"
                                                                                                                                         Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "title", 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatNavMenu\MatNavSubMenuHeader.razor"
                                                                                                                                                     Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddElementReferenceCapture(7, (__value) => {
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatNavMenu\MatNavSubMenuHeader.razor"
                                           Ref = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(8, 
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatNavMenu\MatNavSubMenuHeader.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\n    ");
            __builder.OpenElement(10, "span");
            __builder.AddAttribute(11, "class", "after material-icon mdc-sub-menu-icon");
            __builder.AddAttribute(12, "style", 
#nullable restore
#line 8 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatNavMenu\MatNavSubMenuHeader.razor"
                  ToggleIconStyle

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "&#58131;");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatNavMenu\MatNavSubMenuHeader.razor"
 
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [CascadingParameter]
    public BaseMatNavSubMenu NavSubMenu { get; set; }

    /// <summary>
    /// The title shown.
    /// </summary>
    [Parameter]
    public string Title { get; set; } = null;

    // Forces the toggle icon to collapsed state even when parent is expanded
    protected string ToggleIconStyle => NavSubMenu.Expanded ? "" : "transform: none !important";

    protected override void OnInitialized()
    {
        base.OnInitialized();
        ClassMapper.Add("mat-expansion-panel__summary")
                   .Add("mdc-ripple-surface")
                   .Add("mdc-nav-sub-menu-header")
                   .Add("mdc-list--non-interactive");
        CallAfterRender(async () => { await JsInvokeAsync<object>("matBlazor.matAccordion.initSummary", Ref); });
    }

    protected void OnClickHandler(MouseEventArgs e)
    {
        this.NavSubMenu.ToggleAsync();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
