#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDialog\MatDialogTitle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "280cd3ad3baa6661ecf4829865c32795f9f58c48"
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
#line 2 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDialog\MatDialogTitle.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    public partial class MatDialogTitle : BaseMatDomComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h2");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDialog\MatDialogTitle.razor"
            ClassMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDialog\MatDialogTitle.razor"
                                            StyleMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMultipleAttributes(3, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDialog\MatDialogTitle.razor"
                                                                                             Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Id", 
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDialog\MatDialogTitle.razor"
                                                                                                              Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddElementReferenceCapture(5, (__value) => {
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDialog\MatDialogTitle.razor"
                                                                          Ref = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(6, 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDialog\MatDialogTitle.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDialog\MatDialogTitle.razor"
 

    [Parameter]
    public  RenderFragment ChildContent { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        ClassMapper.Add("mdc-dialog__title");
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
