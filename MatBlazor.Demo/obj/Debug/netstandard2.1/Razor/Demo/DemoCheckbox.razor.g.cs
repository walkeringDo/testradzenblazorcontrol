#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoCheckbox.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb77c319e3e07c4312603e2fdb5f4dc59e9feeb0"
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
    public partial class DemoCheckbox : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.Demo.Doc.DocMatCheckbox>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n\n");
            __builder.AddMarkupContent(2, "<h5 class=\"mat-h5\">Example</h5>\n\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(3);
            __builder.AddAttribute(4, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(5, "div");
                __Blazor.MatBlazor.Demo.Demo.DemoCheckbox.TypeInference.CreateMatCheckbox_0(__builder2, 6, 7, 
#nullable restore
#line 8 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoCheckbox.razor"
                                                          getLabel(checked1)

#line default
#line hidden
#nullable disable
                , 8, 
#nullable restore
#line 8 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoCheckbox.razor"
                                       checked1

#line default
#line hidden
#nullable disable
                , 9, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => checked1 = __value, checked1)), 10, () => checked1);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\n        ");
                __builder2.OpenElement(12, "div");
                __Blazor.MatBlazor.Demo.Demo.DemoCheckbox.TypeInference.CreateMatCheckbox_1(__builder2, 13, 14, 
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoCheckbox.razor"
                                                          getLabel(checked2)

#line default
#line hidden
#nullable disable
                , 15, 
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoCheckbox.razor"
                                       checked2

#line default
#line hidden
#nullable disable
                , 16, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => checked2 = __value, checked2)), 17, () => checked2);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\n        ");
                __builder2.OpenElement(19, "div");
                __Blazor.MatBlazor.Demo.Demo.DemoCheckbox.TypeInference.CreateMatCheckbox_2(__builder2, 20, 21, 
#nullable restore
#line 14 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoCheckbox.razor"
                                                           true

#line default
#line hidden
#nullable disable
                , 22, "Disabled", 23, 
#nullable restore
#line 14 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoCheckbox.razor"
                                       checked1

#line default
#line hidden
#nullable disable
                , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => checked1 = __value, checked1)), 25, () => checked1);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\n        ");
                __builder2.OpenElement(27, "div");
                __Blazor.MatBlazor.Demo.Demo.DemoCheckbox.TypeInference.CreateMatCheckbox_3(__builder2, 28, 29, 
#nullable restore
#line 17 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoCheckbox.razor"
                                       checked2

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => checked2 = __value, checked2)), 31, () => checked2, 32, (__builder3) => {
                    __builder3.AddContent(33, "Inline Label");
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\n        \n        ");
                __builder2.OpenElement(35, "div");
                __Blazor.MatBlazor.Demo.Demo.DemoCheckbox.TypeInference.CreateMatCheckbox_4(__builder2, 36, 37, 
#nullable restore
#line 21 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoCheckbox.razor"
                                                                true

#line default
#line hidden
#nullable disable
                , 38, 
#nullable restore
#line 21 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoCheckbox.razor"
                                       checked3

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => checked3 = __value, checked3)), 40, () => checked3, 41, (__builder3) => {
                    __builder3.AddContent(42, "Indeterminate");
                }
                );
                __builder2.AddMarkupContent(43, "\n            ");
                __builder2.OpenComponent<MatBlazor.MatButton>(44);
                __builder2.AddAttribute(45, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoCheckbox.razor"
                                  _ =>
                                 {
                                     checked3 = null;
                                 }

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(47, "Clear");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(48, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(49);
                __builder2.AddAttribute(50, "Template", "MatBlazor");
                __builder2.AddAttribute(51, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoCheckbox.razor"
                                                  @"
        <div>
            <MatCheckbox @bind-Value=""@checked1"" Label=""@(getLabel(checked1))""></MatCheckbox>
        </div>
        <div>
            <MatCheckbox @bind-Value=""@checked2"" Label=""@(getLabel(checked2))""></MatCheckbox>
        </div>
        <div>
            <MatCheckbox @bind-Value=""@checked1"" Disabled=""true"" Label=""Disabled""></MatCheckbox>
        </div>
        <div>
            <MatCheckbox @bind-Value=""@checked2"">Inline Label</MatCheckbox>
        </div>
        
        <div>
            <MatCheckbox @bind-Value=""@checked3"" Indeterminate=""true"">Indeterminate</MatCheckbox>
            <MatButton OnClick=""@(_ =>
                                 {
                                     checked3 = null;
                                 })"">Clear</MatButton>
        </div>

        @code
        {
            bool checked1 = true;
            bool checked2 = false;
            bool? checked3 = null;

            string getLabel(bool val)
            {
                return !val ? ""Check me!"" : ""Uncheck me?"";
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
#line 29 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoCheckbox.razor"
         
            bool checked1 = true;
            bool checked2 = false;
            bool? checked3 = null;

            string getLabel(bool val)
            {
                return !val ? "Check me!" : "Uncheck me?";
            }

        

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.MatBlazor.Demo.Demo.DemoCheckbox
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatCheckbox_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatCheckbox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatCheckbox_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatCheckbox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatCheckbox_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatCheckbox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Disabled", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMatCheckbox_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatCheckbox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatCheckbox_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatCheckbox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Indeterminate", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
