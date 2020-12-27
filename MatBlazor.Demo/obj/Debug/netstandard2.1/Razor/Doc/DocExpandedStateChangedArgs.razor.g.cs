#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocExpandedStateChangedArgs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27d9eafdac97dcaaa27ca362694a2cfed3bc5794"
// <auto-generated/>
#pragma warning disable 1591
namespace MatBlazor.Demo.Doc
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using MatBlazor.Demo.BlazorFiddle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using MatBlazor.Demo.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using MatBlazor.Demo.Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using MatBlazor.Demo.DemoContainer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using MatBlazor.Demo.Doc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using MatBlazor.Demo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using MatBlazor.Demo.Frames;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\_Imports.razor"
using MatBlazor.Demo.Pages;

#line default
#line hidden
#nullable disable
    public partial class DocExpandedStateChangedArgs : MatBlazor.Demo.Components.BaseDocComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocExpandedStateChangedArgs.razor"
 if (!Secondary) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h3");
            __builder.AddAttribute(1, "class", "mat-h3");
            __builder.AddContent(2, 
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocExpandedStateChangedArgs.razor"
                                      Header

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocExpandedStateChangedArgs.razor"
                                                  } else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "h5");
            __builder.AddAttribute(4, "class", "mat-h5");
            __builder.AddContent(5, 
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocExpandedStateChangedArgs.razor"
                                                                               Header

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocExpandedStateChangedArgs.razor"
                                                                                           }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p>Event arguments passed when a node expanded state changes</p>\n\n");
            __builder.AddMarkupContent(7, @"<div><table class=""article-table mat-elevation-z5 mdc-theme--surface""><tr><th>Name</th>
		<th>Type</th>
		<th>Description</th></tr>
	<tr><td style=""font-weight: bold;"">TNode</td>
		<td>Generic argument</td>
		<td></td></tr>
	<tr><td>NewState</td>
		<td>Boolean</td>
		<td>the new expanded state</td></tr>
	<tr><td>Node</td>
		<td>TNode</td>
		<td>The node that&#39;s expanded state has changed</td></tr></table></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocExpandedStateChangedArgs.razor"
 

	[Parameter]
	public string Header { get; set; } = "ExpandedStateChangedArgs";


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
