#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatHeadline2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab1de5d5ca7ee0b9378a1bcc792a4beea5028e31"
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
    public partial class DocMatHeadline2 : MatBlazor.Demo.Components.BaseDocComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatHeadline2.razor"
 if (!Secondary) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h3");
            __builder.AddAttribute(1, "class", "mat-h3");
            __builder.AddContent(2, 
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatHeadline2.razor"
                                      Header

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatHeadline2.razor"
                                                  } else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "h5");
            __builder.AddAttribute(4, "class", "mat-h5");
            __builder.AddContent(5, 
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatHeadline2.razor"
                                                                               Header

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatHeadline2.razor"
                                                                                           }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, @"<div><table class=""article-table mat-elevation-z5 mdc-theme--surface""><tr><th>Name</th>
		<th>Type</th>
		<th>Description</th></tr>
	<tr><td>Anchor</td>
		<td>Boolean</td>
		<td></td></tr>
	<tr><td>AnchorId</td>
		<td>String</td>
		<td></td></tr>
	<tr><td>Attributes</td>
		<td>Dictionary&lt;String,Object&gt;</td>
		<td>Gets or sets a collection of additional attributes that will be applied to the created element.</td></tr>
	<tr><td>ChildContent</td>
		<td>RenderFragment</td>
		<td>Child content of MatHeadline2</td></tr>
	<tr><td>Class</td>
		<td>String</td>
		<td>Specifies one or more classnames for an DOM element.</td></tr>
	<tr><td>Id</td>
		<td>String</td>
		<td></td></tr>
	<tr><td>RefBack</td>
		<td>ForwardRef</td>
		<td></td></tr>
	<tr><td>Style</td>
		<td>String</td>
		<td>Specifies an inline style for an DOM element.</td></tr>
	<tr><td>Tag</td>
		<td>String</td>
		<td></td></tr>
	<tr><td>Ref</td>
		<td>ElementReference</td>
		<td>Returned ElementRef reference for DOM element.</td></tr></table></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatHeadline2.razor"
 

	[Parameter]
	public string Header { get; set; } = "MatHeadline2";


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
