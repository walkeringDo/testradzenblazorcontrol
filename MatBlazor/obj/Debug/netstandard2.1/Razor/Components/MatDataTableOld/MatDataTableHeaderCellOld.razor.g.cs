#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableHeaderCellOld.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e52d58d385d84232234bb955e0d53b715d70fc64"
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
    public partial class MatDataTableHeaderCellOld : BaseMatDomComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "th");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableHeaderCellOld.razor"
            ClassMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableHeaderCellOld.razor"
                                            StyleMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "id", 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableHeaderCellOld.razor"
                                                                                    Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddMultipleAttributes(4, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableHeaderCellOld.razor"
                                                                                                      Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "role", "columnheader");
            __builder.AddAttribute(6, "scope", "col");
            __builder.AddElementReferenceCapture(7, (__value) => {
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableHeaderCellOld.razor"
                                                                          Ref = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(8, 
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableHeaderCellOld.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableHeaderCellOld.razor"
 
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public bool Numeric { get; set; }


    protected override void OnInitialized()
    {
        base.OnInitialized();
        ClassMapper
            .Add("mdc-data-table__header-cell")
            .If("mdc-data-table__header-cell--numeric", () => Numeric);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591