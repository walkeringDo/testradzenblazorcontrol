#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatSelectValue.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b4f03c48228823de6f0544a745aba1619a8264e"
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
    public partial class CoreMatSelectValue<TValue, TItem> : BaseCoreMatSelectValue<TValue, TItem>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddContent(0, 
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatSelectValue.razor"
 base.BuildRenderTree

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatSelectValue.razor"
 
    protected override RenderFragment GetChildContent()
    {
        return
            

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenComponent<MatBlazor.MatContentWrapper>(1);
            __builder2.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 14 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatSelectValue.razor"
                 if (Items != null)
                {
                    for (int i = 0; i < Items.Count; i++)
                    {
                        var item = Items[i];

#line default
#line hidden
#nullable disable
                __Blazor.MatBlazor.CoreMatSelectValue.TypeInference.CreateMatOption_0(__builder3, 3, 4, 
#nullable restore
#line 19 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatSelectValue.razor"
                                           i

#line default
#line hidden
#nullable disable
                , 5, (__builder4) => {
#nullable restore
#line 20 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatSelectValue.razor"
                             if (ItemTemplate == null)
                            {
                                

#line default
#line hidden
#nullable disable
                    __builder4.AddContent(6, 
#nullable restore
#line 22 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatSelectValue.razor"
                                 item

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 22 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatSelectValue.razor"
                                     
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
                    __builder4.AddContent(7, 
#nullable restore
#line 26 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatSelectValue.razor"
                                 ItemTemplate(item)

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 26 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatSelectValue.razor"
                                                                                   
                            }

#line default
#line hidden
#nullable disable
                }
                );
#nullable restore
#line 29 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatSelectValue.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder2.CloseComponent();
        }
#nullable restore
#line 31 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatSelectValue.razor"
                                ;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.MatBlazor.CoreMatSelectValue
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatOption_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MatBlazor.MatOption<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
