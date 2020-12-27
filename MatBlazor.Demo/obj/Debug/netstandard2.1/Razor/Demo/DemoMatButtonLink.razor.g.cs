#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a3538037eba1fee54ce8d1ef44245cd838c9c57"
// <auto-generated/>
#pragma warning disable 1591
namespace MatBlazor.Demo.Demo
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#nullable restore
#line 1 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    public partial class DemoMatButtonLink : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.Demo.Doc.DocMatButtonLink>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n\n");
            __builder.AddMarkupContent(2, "<h5 class=\"mat-h5\">Example</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(3);
            __builder.AddAttribute(4, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<h4 class=\"mat-subtitle1\">Simple use</h4>\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(6);
                __builder2.AddAttribute(7, "Icon", "favorite");
                __builder2.AddAttribute(8, "Href", "/ButtonLink");
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(10, "Link to this page");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n\n        ");
                __builder2.AddMarkupContent(12, "<h4 class=\"mat-subtitle1\">Link with OnClick event handler</h4>\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(13);
                __builder2.AddAttribute(14, "Icon", "favorite");
                __builder2.AddAttribute(15, "Href", "/ButtonLink");
                __builder2.AddAttribute(16, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                                    RunOnClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(18, "Link with click event");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n\n        ");
                __builder2.AddMarkupContent(20, "<h5 class=\"mat-subtitle1\">With Font-Awesome Icons and Link</h5>\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(21);
                __builder2.AddAttribute(22, "Href", "https://github.com/BlazorComponents/MatBlazor");
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(24, "<i class=\"fa fa-github\" aria-hidden=\"true\"></i> &nbsp; Github\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\n        \n        ");
                __builder2.AddMarkupContent(26, "<h5 class=\"mat-subtitle1\">Link to internal page</h5>\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(27);
                __builder2.AddAttribute(28, "Href", "/Checkbox");
                __builder2.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(30, "Go to Checkbox");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\n\n        ");
                __builder2.AddMarkupContent(32, "<h5 class=\"mat-subtitle1\">Internal Link with ForceLoad</h5>\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(33);
                __builder2.AddAttribute(34, "Href", "/Checkbox");
                __builder2.AddAttribute(35, "ForceLoad", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(37, "ForceLoad - Go to Checkbox");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\n\n        ");
                __builder2.AddMarkupContent(39, "<h5 class=\"mat-subtitle1\">With Font-Awesome Icons and Link in a new Window  - Target Defined</h5>\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(40);
                __builder2.AddAttribute(41, "Href", "https://github.com/BlazorComponents/MatBlazor");
                __builder2.AddAttribute(42, "Target", "_blank");
                __builder2.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(44, "<i class=\"fa fa-github\" aria-hidden=\"true\"></i> &nbsp; Github\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\n\n        ");
                __builder2.AddMarkupContent(46, "<h5 class=\"mat-subtitle1\">Internal Link in a new Window - Target Defined</h5>\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(47);
                __builder2.AddAttribute(48, "Href", "/TextField");
                __builder2.AddAttribute(49, "Target", "_blank");
                __builder2.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(51, "<i class=\"fa fa-paragraph\" aria-hidden=\"true\"></i> &nbsp; TextField\n        ");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(52, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(53);
                __builder2.AddAttribute(54, "Template", "MatBlazor");
                __builder2.AddAttribute(55, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                  @"
        <h4 class=""mat-subtitle1"">Simple use</h4>
        <MatButtonLink Icon=""favorite"" Href=""/ButtonLink"">Link to this page</MatButtonLink>

        <h4 class=""mat-subtitle1"">Link with OnClick event handler</h4>
        <MatButtonLink Icon=""favorite"" Href=""/ButtonLink"" OnClick=""@RunOnClick"">Link with click event</MatButtonLink>

        <h5 class=""mat-subtitle1"">With Font-Awesome Icons and Link</h5>
        <MatButtonLink Href=""https://github.com/BlazorComponents/MatBlazor"">
            <i class=""fa fa-github"" aria-hidden=""true""></i> &nbsp; Github
        </MatButtonLink>
        
        <h5 class=""mat-subtitle1"">Link to internal page</h5>
        <MatButtonLink Href=""/Checkbox"">Go to Checkbox</MatButtonLink>

        <h5 class=""mat-subtitle1"">Internal Link with ForceLoad</h5>
        <MatButtonLink Href=""/Checkbox"" ForceLoad=""true"">ForceLoad - Go to Checkbox</MatButtonLink>

        <h5 class=""mat-subtitle1"">With Font-Awesome Icons and Link in a new Window  - Target Defined</h5>
        <MatButtonLink Href=""https://github.com/BlazorComponents/MatBlazor"" Target=""_blank"">
            <i class=""fa fa-github"" aria-hidden=""true""></i> &nbsp; Github
        </MatButtonLink>

        <h5 class=""mat-subtitle1"">Internal Link in a new Window - Target Defined</h5>
        <MatButtonLink Href=""/TextField"" Target=""_blank"">
            <i class=""fa fa-paragraph"" aria-hidden=""true""></i> &nbsp; TextField
        </MatButtonLink>

        @code
        {

            public void RunOnClick(MouseEventArgs e)
            {
                JsRuntime.InvokeAsync<object>(""window.alert"", ""Test"");
            }

        }

    "

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\n\n");
            __builder.AddMarkupContent(57, "<h5 class=\"mat-h5\">Link types</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(58);
            __builder.AddAttribute(59, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(60);
                __builder2.AddAttribute(61, "Href", "/ButtonLink");
                __builder2.AddAttribute(62, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                    Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(64, "Text ");
                    __builder3.AddContent(65, 
#nullable restore
#line 93 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                                 LinkState

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(67);
                __builder2.AddAttribute(68, "Href", "/ButtonLink");
                __builder2.AddAttribute(69, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 94 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(71, "Raised");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(73);
                __builder2.AddAttribute(74, "Href", "/ButtonLink");
                __builder2.AddAttribute(75, "Unelevated", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 95 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(77, "Unelevated");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(79);
                __builder2.AddAttribute(80, "Href", "/ButtonLink");
                __builder2.AddAttribute(81, "Outlined", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 96 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(83, "Outlined");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(85);
                __builder2.AddAttribute(86, "Href", "/ButtonLink");
                __builder2.AddAttribute(87, "Dense", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 97 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(89, "Dense");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(90, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(91);
                __builder2.AddAttribute(92, "Template", "MatBlazor");
                __builder2.AddAttribute(93, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 112 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                  @"
        <MatButtonLink Href=""/ButtonLink"" OnClick=""@Click"">Text @LinkState</MatButtonLink>
        <MatButtonLink Href=""/ButtonLink"" Raised=""true"">Raised</MatButtonLink>
        <MatButtonLink Href=""/ButtonLink"" Unelevated=""true"">Unelevated</MatButtonLink>
        <MatButtonLink Href=""/ButtonLink"" Outlined=""true"">Outlined</MatButtonLink>
        <MatButtonLink Href=""/ButtonLink"" Dense=""true"">Dense</MatButtonLink>

        @code
        {
            string LinkState = """";

            void Click(MouseEventArgs e)
            {
                LinkState = ""Clicked"";
            }

        }

    "

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(94, "\n\n");
            __builder.AddMarkupContent(95, "<h5 class=\"mat-h5\">Disabled</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(96);
            __builder.AddAttribute(97, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(98);
                __builder2.AddAttribute(99, "Href", "/ButtonLink");
                __builder2.AddAttribute(100, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 137 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(102, "Text");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(103, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(104);
                __builder2.AddAttribute(105, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(106, "Link without Href");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(107, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(108);
                __builder2.AddAttribute(109, "Href", "/ButtonLink");
                __builder2.AddAttribute(110, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 139 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(111, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 139 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(112, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(113, "Raised");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(114, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(115);
                __builder2.AddAttribute(116, "Href", "/ButtonLink");
                __builder2.AddAttribute(117, "Unelevated", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 140 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(118, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 140 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(119, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(120, "Unelevated");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(121, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(122);
                __builder2.AddAttribute(123, "Href", "/ButtonLink");
                __builder2.AddAttribute(124, "Outlined", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 141 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(125, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 141 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(126, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(127, "Outlined");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(128, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(129);
                __builder2.AddAttribute(130, "Href", "/ButtonLink");
                __builder2.AddAttribute(131, "Dense", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 142 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(132, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 142 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(133, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(134, "Dense");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(135, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(136);
                __builder2.AddAttribute(137, "Template", "MatBlazor");
                __builder2.AddAttribute(138, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 145 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                  @"
        <MatButtonLink Href=""/ButtonLink"" Disabled=""true"">Text</MatButtonLink>
        <MatButtonLink>Link without Href</MatButtonLink>
        <MatButtonLink Href=""/ButtonLink"" Raised=""true"" Disabled=""true"">Raised</MatButtonLink>
        <MatButtonLink Href=""/ButtonLink"" Unelevated=""true"" Disabled=""true"">Unelevated</MatButtonLink>
        <MatButtonLink Href=""/ButtonLink"" Outlined=""true"" Disabled=""true"">Outlined</MatButtonLink>
        <MatButtonLink Href=""/ButtonLink"" Dense=""true"" Disabled=""true"">Dense</MatButtonLink>
    "

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(139, "\n\n\n");
            __builder.AddMarkupContent(140, "<h5 class=\"mat-h5\">Icons</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(141);
            __builder.AddAttribute(142, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(143);
                __builder2.AddAttribute(144, "Href", "/ButtonLink");
                __builder2.AddAttribute(145, "Icon", "favorite");
                __builder2.AddAttribute(146, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(147, "Text");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(148, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(149);
                __builder2.AddAttribute(150, "Href", "/ButtonLink");
                __builder2.AddAttribute(151, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 161 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(152, "Icon", "favorite");
                __builder2.AddAttribute(153, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(154, "Raised");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(155, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(156);
                __builder2.AddAttribute(157, "Href", "/ButtonLink");
                __builder2.AddAttribute(158, "Unelevated", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 162 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(159, "Icon", "favorite");
                __builder2.AddAttribute(160, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(161, "Unelevated");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(162, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(163);
                __builder2.AddAttribute(164, "Href", "/ButtonLink");
                __builder2.AddAttribute(165, "Outlined", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 163 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(166, "Icon", "favorite");
                __builder2.AddAttribute(167, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(168, "Outlined");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(169, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(170);
                __builder2.AddAttribute(171, "Href", "/ButtonLink");
                __builder2.AddAttribute(172, "Dense", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 164 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(173, "Icon", "favorite");
                __builder2.AddAttribute(174, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(175, "Dense");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(176, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(177);
                __builder2.AddAttribute(178, "Template", "MatBlazor");
                __builder2.AddAttribute(179, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 167 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                  @"
        <MatButtonLink Href=""/ButtonLink"" Icon=""favorite"">Text</MatButtonLink>
        <MatButtonLink Href=""/ButtonLink"" Raised=""true"" Icon=""favorite"">Raised</MatButtonLink>
        <MatButtonLink Href=""/ButtonLink"" Unelevated=""true"" Icon=""favorite"">Unelevated</MatButtonLink>
        <MatButtonLink Href=""/ButtonLink"" Outlined=""true"" Icon=""favorite"">Outlined</MatButtonLink>
        <MatButtonLink Href=""/ButtonLink"" Dense=""true"" Icon=""favorite"">Dense</MatButtonLink>
    "

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(180, "\n\n");
            __builder.AddMarkupContent(181, "<h5 class=\"mat-h5\">Trailing Icons</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(182);
            __builder.AddAttribute(183, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(184);
                __builder2.AddAttribute(185, "Href", "/ButtonLink");
                __builder2.AddAttribute(186, "TrailingIcon", "favorite");
                __builder2.AddAttribute(187, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(188, "Text");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(189, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(190);
                __builder2.AddAttribute(191, "Href", "/ButtonLink");
                __builder2.AddAttribute(192, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 181 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(193, "TrailingIcon", "favorite");
                __builder2.AddAttribute(194, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(195, "Raised");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(196, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(197);
                __builder2.AddAttribute(198, "Href", "/ButtonLink");
                __builder2.AddAttribute(199, "Unelevated", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 182 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(200, "TrailingIcon", "favorite");
                __builder2.AddAttribute(201, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(202, "Unelevated");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(203, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(204);
                __builder2.AddAttribute(205, "Href", "/ButtonLink");
                __builder2.AddAttribute(206, "Outlined", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 183 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(207, "TrailingIcon", "favorite");
                __builder2.AddAttribute(208, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(209, "Outlined");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(210, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatButtonLink>(211);
                __builder2.AddAttribute(212, "Href", "/ButtonLink");
                __builder2.AddAttribute(213, "Dense", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 184 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(214, "TrailingIcon", "favorite");
                __builder2.AddAttribute(215, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(216, "Dense");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(217, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(218);
                __builder2.AddAttribute(219, "Template", "MatBlazor");
                __builder2.AddAttribute(220, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 187 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
                                                  @"
        <MatButtonLink Href=""/ButtonLink"" TrailingIcon=""favorite"">Text</MatButtonLink>
        <MatButtonLink Href=""/ButtonLink"" Raised=""true"" TrailingIcon=""favorite"">Raised</MatButtonLink>
        <MatButtonLink Href=""/ButtonLink"" Unelevated=""true"" TrailingIcon=""favorite"">Unelevated</MatButtonLink>
        <MatButtonLink Href=""/ButtonLink"" Outlined=""true"" TrailingIcon=""favorite"">Outlined</MatButtonLink>
        <MatButtonLink Href=""/ButtonLink"" Dense=""true"" TrailingIcon=""favorite"">Dense</MatButtonLink>
    "

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
         

            public void RunOnClick(MouseEventArgs e)
            {
                JsRuntime.InvokeAsync<object>("window.alert", "Test");
            }

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatButtonLink.razor"
         
            string LinkState = "";

            void Click(MouseEventArgs e)
            {
                LinkState = "Clicked";
            }

        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
