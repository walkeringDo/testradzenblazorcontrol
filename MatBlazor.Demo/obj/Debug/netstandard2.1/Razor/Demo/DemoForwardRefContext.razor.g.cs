#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoForwardRefContext.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2665fb0faa3ca167d98e814cc7ce8f5a4b2bda3b"
// <auto-generated/>
#pragma warning disable 1591
namespace MatBlazor.Demo.Demo
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
    public partial class DemoForwardRefContext : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.Demo.Doc.DocForwardRefContext>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n\n\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(2);
            __builder.AddAttribute(3, "Header", "Reference to DOM elements");
            __builder.AddAttribute(4, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 8 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoForwardRefContext.razor"
         foreach (var item in items)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MatBlazor.ForwardRefContext<ElementReference>>(5);
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<MatBlazor.ForwardRef<ElementReference>>)((context) => (__builder3) => {
                    __builder3.OpenElement(7, "div");
                    __builder3.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoForwardRefContext.razor"
                                                         _ => OnDivClick(context.Current)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddElementReferenceCapture(9, (__value) => {
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoForwardRefContext.razor"
                            context.Current = __value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.AddContent(10, 
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoForwardRefContext.razor"
                                                                                             item

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                }
                ));
                __builder2.SetKey(
#nullable restore
#line 10 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoForwardRefContext.razor"
                                                              item

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
#nullable restore
#line 13 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoForwardRefContext.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(11, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(12);
                __builder2.AddAttribute(13, "Template", "MatBlazor");
                __builder2.AddAttribute(14, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoForwardRefContext.razor"
                                                  @"
        @inject IJSRuntime jsRuntime

        @foreach (var item in items)
        {
            <ForwardRefContext TRef=""ElementReference"" @key=""@item"">
                <div @ref=""@context.Current"" @onclick=""@(_ => OnDivClick(context.Current))"">@item</div>
            </ForwardRefContext>
        }

        @code
        {

            string[] items = Enumerable.Range(1, 10).Select(i => i.ToString()).ToArray();

            void OnDivClick(ElementReference reference)
            {
            // you can check in DeveloperTools
                jsRuntime.InvokeAsync<object>(""console.log"", reference);
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
            __builder.AddMarkupContent(15, "\n\n\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(16);
            __builder.AddAttribute(17, "Header", "Reference to Components");
            __builder.AddAttribute(18, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 58 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoForwardRefContext.razor"
         foreach (var item in items2)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MatBlazor.ForwardRefContext<MatTextField<string>>>(19);
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<MatBlazor.ForwardRef<MatTextField<string>>>)((context) => (__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatTextField<string>>(21);
                    __builder3.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 61 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoForwardRefContext.razor"
                                                                              item

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddComponentReferenceCapture(23, (__value) => {
#nullable restore
#line 61 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoForwardRefContext.razor"
                                     context.Current = (MatBlazor.MatTextField<string>)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\n                ");
                    __builder3.OpenComponent<MatBlazor.MatIconButton>(25);
                    __builder3.AddAttribute(26, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoForwardRefContext.razor"
                                      MatIconNames.Clear

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoForwardRefContext.razor"
                                                                     _ => DisableTextField(context.Current)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.SetKey(
#nullable restore
#line 60 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoForwardRefContext.razor"
                                                                  item

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
#nullable restore
#line 64 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoForwardRefContext.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(28, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(29);
                __builder2.AddAttribute(30, "Template", "MatBlazor");
                __builder2.AddAttribute(31, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 80 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoForwardRefContext.razor"
                                                  @"
        @foreach (var item in items2)
        {
            <ForwardRefContext TRef=""MatTextField<string>"" @key=""@item"">
                <MatTextField @ref=""@context.Current"" TValue=""string"" Value=""@item""></MatTextField>
                <MatIconButton Icon=""@MatIconNames.Clear"" OnClick=""@(_ => DisableTextField(context.Current))""></MatIconButton>
            </ForwardRefContext>
        }

        @code
        {

            string[] items2 = Enumerable.Range(1, 10).Select(i => i.ToString()).ToArray();

            void DisableTextField(MatTextField<string> textFieldReference)
            {
                textFieldReference.Disabled = true;
                textFieldReference.InvokeStateHasChanged();
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
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoForwardRefContext.razor"
         

            string[] items = Enumerable.Range(1, 10).Select(i => i.ToString()).ToArray();

            void OnDivClick(ElementReference reference)
            {
            // you can check in DeveloperTools
                jsRuntime.InvokeAsync<object>("console.log", reference);
            }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoForwardRefContext.razor"
         

            string[] items2 = Enumerable.Range(1, 10).Select(i => i.ToString()).ToArray();

            void DisableTextField(MatTextField<string> textFieldReference)
            {
                textFieldReference.Disabled = true;
                textFieldReference.InvokeStateHasChanged();
            }
        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
