// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class MatDataTableCellOld : BaseMatDomComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableCellOld.razor"
 
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public bool Numeric { get; set; }


    protected override void OnInitialized()
    {
        base.OnInitialized();
        ClassMapper
            .Add("mdc-data-table__cell")
            .If("mdc-data-table__cell--numeric", () => Numeric);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591