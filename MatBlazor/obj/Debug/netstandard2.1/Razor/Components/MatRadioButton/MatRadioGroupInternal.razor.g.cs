#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioGroupInternal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2c81cc882c26c5edce743f518af38d25bafebd1"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class MatRadioGroupInternal<TValue> : BaseMatRadioGroupInternal<TValue>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.MatBlazor.MatRadioGroupInternal.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioGroupInternal.razor"
                        this

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioGroupInternal.razor"
     if (Items != null)
    {
        foreach (var item in Items)
        {
            if (ItemTemplate != null)
            {
                

#line default
#line hidden
#nullable disable
                __builder2.AddContent(3, 
#nullable restore
#line 13 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioGroupInternal.razor"
                 ItemTemplate(item)

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 13 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioGroupInternal.razor"
                                   
            }
            else
            {

#line default
#line hidden
#nullable disable
                __Blazor.MatBlazor.MatRadioGroupInternal.TypeInference.CreateMatRadioButton_1(__builder2, 4, 5, "T", 6, 
#nullable restore
#line 17 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioGroupInternal.razor"
                                              item

#line default
#line hidden
#nullable disable
                , 7, (__builder3) => {
                    __builder3.AddContent(8, 
#nullable restore
#line 17 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioGroupInternal.razor"
                                                     item

#line default
#line hidden
#nullable disable
                    );
                }
                );
#nullable restore
#line 18 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioGroupInternal.razor"
            }
        }
    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(9, 
#nullable restore
#line 22 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatRadioButton\MatRadioGroupInternal.razor"
     ChildContent

#line default
#line hidden
#nullable disable
                );
            }
            );
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.MatBlazor.MatRadioGroupInternal
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMatRadioButton_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::MatBlazor.MatRadioButton<TValue>>(seq);
        __builder.AddAttribute(__seq0, "T", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
