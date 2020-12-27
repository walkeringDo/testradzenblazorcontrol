#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatNavItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ec7a1b8f16da78ba4b3fb5fdefe4a8903fb7179"
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
    public partial class DocMatNavItem : MatBlazor.Demo.Components.BaseDocComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatNavItem.razor"
 if (!Secondary) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h3");
            __builder.AddAttribute(1, "class", "mat-h3");
            __builder.AddContent(2, 
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatNavItem.razor"
                                      Header

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatNavItem.razor"
                                                  } else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "h5");
            __builder.AddAttribute(4, "class", "mat-h5");
            __builder.AddContent(5, 
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatNavItem.razor"
                                                                               Header

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatNavItem.razor"
                                                                                           }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p>Nav Item is a menu item in the Nav Menu. Inherits from Mat List Item.</p>\n\n");
            __builder.AddMarkupContent(7, "<div><table class=\"article-table mat-elevation-z5 mdc-theme--surface\"><tr><th>Name</th>\n\t\t<th>Type</th>\n\t\t<th>Description</th></tr>\n\t<tr><td>AllowSelection</td>\n\t\t<td>Boolean</td>\n\t\t<td>Specifies weather you the Nav Item can be selected / active.</td></tr>\n\t<tr><td>Attributes</td>\n\t\t<td>Dictionary&lt;String,Object&gt;</td>\n\t\t<td>Gets or sets a collection of additional attributes that will be applied to the created element.</td></tr>\n\t<tr><td>ChildContent</td>\n\t\t<td>RenderFragment</td>\n\t\t<td>Child content of MatNavItem</td></tr>\n\t<tr><td>Class</td>\n\t\t<td>String</td>\n\t\t<td>Specifies one or more classnames for an DOM element.</td></tr>\n\t<tr><td>Command</td>\n\t\t<td>ICommand</td>\n\t\t<td>Command executed when the user clicks on an element.</td></tr>\n\t<tr><td>CommandParameter</td>\n\t\t<td>Object</td>\n\t\t<td>Command parameter.</td></tr>\n\t<tr><td>Disabled</td>\n\t\t<td>Boolean</td>\n\t\t<td>List Item is disabled.</td></tr>\n\t<tr><td>ForceLoad</td>\n\t\t<td>Boolean</td>\n\t\t<td>Force browser to redirect outside component router-space.</td></tr>\n\t<tr><td>Href</td>\n\t\t<td>String</td>\n\t\t<td>The URL of the List Item</td></tr>\n\t<tr><td>Id</td>\n\t\t<td>String</td>\n\t\t<td></td></tr>\n\t<tr><td>NavLinkMatch</td>\n\t\t<td>NavLinkMatch</td>\n\t\t<td>NavLinkMatch parameter used to determine the active state of the Nav Item.</td></tr>\n\t<tr><td>OnClick</td>\n\t\t<td>EventCallback&lt;MouseEventArgs&gt;</td>\n\t\t<td></td></tr>\n\t<tr><td>OnMouseDown</td>\n\t\t<td>EventCallback&lt;MouseEventArgs&gt;</td>\n\t\t<td></td></tr>\n\t<tr><td>RefBack</td>\n\t\t<td>ForwardRef</td>\n\t\t<td></td></tr>\n\t<tr><td>Selected</td>\n\t\t<td>Boolean</td>\n\t\t<td></td></tr>\n\t<tr><td>SelectedChanged</td>\n\t\t<td>EventCallback&lt;Boolean&gt;</td>\n\t\t<td></td></tr>\n\t<tr><td>Style</td>\n\t\t<td>String</td>\n\t\t<td>Specifies an inline style for an DOM element.</td></tr>\n\t<tr><td>Target</td>\n\t\t<td>String</td>\n\t\t<td>*Not yet functional - Target of Href when clicked.</td></tr>\n\t<tr><td>Title</td>\n\t\t<td>String</td>\n\t\t<td>The title shown.</td></tr>\n\t<tr><td>Ref</td>\n\t\t<td>ElementReference</td>\n\t\t<td>Returned ElementRef reference for DOM element.</td></tr></table></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 121 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Doc\DocMatNavItem.razor"
 

	[Parameter]
	public string Header { get; set; } = "MatNavItem";


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591