#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoBaseMatComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7e5c7f08cb1f9fa90f28714dc295c8510a5cc67"
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
#line 1 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoBaseMatComponent.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    public partial class DemoBaseMatComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"mat-h3\">BaseMatComponent</h3>\n\n");
            __builder.AddMarkupContent(1, "<p class=\"mat-body1\">BaseMatComponent contains base component parameters and features.</p>\n\n");
            __builder.AddMarkupContent(2, "<h5 class=\"mat-h5\">@Attributes and Id</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(3);
            __builder.AddAttribute(4, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatButton>(5);
                __builder2.AddAttribute(6, "customTest", "123");
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(8, "Button with custom attribute");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatStringField>(10);
                __builder2.AddAttribute(11, "customTest", "123");
                __builder2.AddAttribute(12, "Label", "TextField with custom attribute");
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(13, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(14);
                __builder2.AddAttribute(15, "Template", "MatBlazor");
                __builder2.AddAttribute(16, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoBaseMatComponent.razor"
                                                  @"
        <MatButton customTest=""123"">Button with custom attribute</MatButton>
        <MatStringField customTest=""123"" Label=""TextField with custom attribute""></MatStringField>
    "

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\n\n\n");
            __builder.AddMarkupContent(18, "<h5 class=\"mat-h5\">Capture of Reference of the component using <a href=\"/ForwardRef\">ForwardRef</a></h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(19);
            __builder.AddAttribute(20, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatButton>(21);
                __builder2.AddAttribute(22, "RefBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MatBlazor.ForwardRef>(
#nullable restore
#line 26 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoBaseMatComponent.razor"
                            buttonRefBack

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoBaseMatComponent.razor"
                                                     Click2

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(25, "Get me Ref");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(26, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(27);
                __builder2.AddAttribute(28, "Template", "MatBlazor");
                __builder2.AddAttribute(29, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoBaseMatComponent.razor"
                                                  @"


        <MatButton RefBack=""buttonRefBack"" OnClick=""@Click2"">Get me Ref</MatButton>

        @code
        {
            ForwardRef buttonRefBack = new ForwardRef();

            void Click2(MouseEventArgs e)
            {
            // buttonRefBack.Current - Reference for Dom Element of button
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
            __builder.AddMarkupContent(30, "\n\n\n");
            __builder.AddMarkupContent(31, "<h5 class=\"mat-h5\">Capture of Reference of the component</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(32);
            __builder.AddAttribute(33, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatButton>(34);
                __builder2.AddAttribute(35, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoBaseMatComponent.razor"
                                              Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(37, "Get me Ref");
                }
                ));
                __builder2.AddComponentReferenceCapture(38, (__value) => {
#nullable restore
#line 65 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoBaseMatComponent.razor"
                         ButtonRef = (MatBlazor.MatButton)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(39, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(40);
                __builder2.AddAttribute(41, "Template", "MatBlazor");
                __builder2.AddAttribute(42, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 81 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoBaseMatComponent.razor"
                                                  @"
        <MatButton @ref=""ButtonRef"" OnClick=""@Click"">Get me Ref</MatButton>

        @code
        {
            MatButton ButtonRef;

            void Click(MouseEventArgs e)
            {
            // this.ButtonRef - Reference for MatButton component
            // this.ButtonRef.Ref - Reference for Dom Element of button
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
            __builder.AddMarkupContent(43, "\n\n\n");
            __builder.AddMarkupContent(44, "<h5 class=\"mat-h5\">Apply css Class to MatBlazor Components</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(45);
            __builder.AddAttribute(46, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(47, "<style>\n            .my-button-class { background: lightcoral !important; }\n        </style>\n\n        ");
                __builder2.OpenComponent<MatBlazor.MatButton>(48);
                __builder2.AddAttribute(49, "Class", "my-button-class");
                __builder2.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(51, "Button with class");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatIconButton>(53);
                __builder2.AddAttribute(54, "Class", "my-button-class");
                __builder2.AddAttribute(55, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 109 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoBaseMatComponent.razor"
                                                      MatIconNames.Favorite

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(56, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(57);
                __builder2.AddAttribute(58, "Template", "MatBlazor");
                __builder2.AddAttribute(59, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 112 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoBaseMatComponent.razor"
                                                  @"
        <style>
            .my-button-class { background: lightcoral !important; }
        </style>

        <MatButton Class=""my-button-class"">Button with class</MatButton>
        <MatIconButton Class=""my-button-class"" Icon=""@MatIconNames.Favorite""></MatIconButton>
    "

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\n\n");
            __builder.AddMarkupContent(61, "<h5 class=\"mat-h5\">Apply style to MatBlazor Components</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(62);
            __builder.AddAttribute(63, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatButton>(64);
                __builder2.AddAttribute(65, "Style", "background: lightcoral;");
                __builder2.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(67, "Button with style");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\n        ");
                __builder2.OpenComponent<MatBlazor.MatIconButton>(69);
                __builder2.AddAttribute(70, "Style", "background: lightcoral;");
                __builder2.AddAttribute(71, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 127 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoBaseMatComponent.razor"
                                                              MatIconNames.Favorite

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(72, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(73);
                __builder2.AddAttribute(74, "Template", "MatBlazor");
                __builder2.AddAttribute(75, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 130 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoBaseMatComponent.razor"
                                                  @"
        <MatButton Style=""background: lightcoral;"">Button with style</MatButton>
        <MatIconButton Style=""background: lightcoral;"" Icon=""@MatIconNames.Favorite""></MatIconButton>
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
#line 29 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoBaseMatComponent.razor"
         
            ForwardRef buttonRefBack = new ForwardRef();

            void Click2(MouseEventArgs e)
            {
            // buttonRefBack.Current - Reference for Dom Element of button
            }

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoBaseMatComponent.razor"
         
            MatButton ButtonRef;

            void Click(MouseEventArgs e)
            {
            // this.ButtonRef - Reference for MatButton component
            // this.ButtonRef.Ref - Reference for Dom Element of button
            }

        

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
