#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatProgressCircle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da684ad17a569cacfaaf628dc746d2ef0fd0bd47"
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
    public partial class DocMatProgressCircle : MatBlazor.Demo.Components.BaseDocComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatProgressCircle.razor"
 if (!Secondary) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h3");
            __builder.AddAttribute(1, "class", "mat-h3");
            __builder.AddContent(2, 
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatProgressCircle.razor"
                                      Header

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatProgressCircle.razor"
                                                  } else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "h5");
            __builder.AddAttribute(4, "class", "mat-h5");
            __builder.AddContent(5, 
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatProgressCircle.razor"
                                                                               Header

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatProgressCircle.razor"
                                                                                           }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p>Circular Progress indicator displays the length of a process or express an unspecified wait time.</p>\n\n");
            __builder.AddMarkupContent(7, @"<div><table class=""article-table mat-elevation-z5 mdc-theme--surface""><tr><th>Name</th>
		<th>Type</th>
		<th>Description</th></tr>
	<tr><td>Attributes</td>
		<td>Dictionary&lt;String,Object&gt;</td>
		<td>Gets or sets a collection of additional attributes that will be applied to the created element.</td></tr>
	<tr><td>Class</td>
		<td>String</td>
		<td>Specifies one or more classnames for an DOM element.</td></tr>
	<tr><td>Closed</td>
		<td>Boolean</td>
		<td>If true, Puts the component in the closed state.</td></tr>
	<tr><td>FourColored</td>
		<td>Boolean</td>
		<td>IF true, Applies four animated stroke-colors to the indeterminate indicator. Applicable to the indeterminate variant only and overrides any single color currently set.</td></tr>
	<tr><td>Id</td>
		<td>String</td>
		<td></td></tr>
	<tr><td>Indeterminate</td>
		<td>Boolean</td>
		<td>Toggles the component between the determinate and indeterminate state.</td></tr>
	<tr><td>Progress</td>
		<td>Double</td>
		<td>Sets the progress bar to this value. Value should be between [0, 1].</td></tr>
	<tr><td>RefBack</td>
		<td>ForwardRef</td>
		<td></td></tr>
	<tr><td>Size</td>
		<td>MatProgressCircleSize</td>
		<td>Sets the size of the circular progress bar.</td></tr>
	<tr><td>Style</td>
		<td>String</td>
		<td>Specifies an inline style for an DOM element.</td></tr>
	<tr><td>Ref</td>
		<td>ElementReference</td>
		<td>Returned ElementRef reference for DOM element.</td></tr></table></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatProgressCircle.razor"
 

	[Parameter]
	public string Header { get; set; } = "MatProgressCircle";


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591