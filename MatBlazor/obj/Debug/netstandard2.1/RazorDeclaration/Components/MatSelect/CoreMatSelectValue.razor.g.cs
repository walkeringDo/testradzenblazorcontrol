// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
            __builder2.OpenElement(0, "MatContentWrapper");
            __builder2.AddMarkupContent(1, "\n");
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
            __builder2.AddContent(2, "                        ");
            __builder2.OpenElement(3, "MatOption");
            __builder2.AddAttribute(4, "Value", 
#nullable restore
#line 19 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatSelectValue.razor"
                                           i

#line default
#line hidden
#nullable disable
            );
            __builder2.AddMarkupContent(5, "\n");
#nullable restore
#line 20 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatSelectValue.razor"
                             if (ItemTemplate == null)
                            {
                                

#line default
#line hidden
#nullable disable
            __builder2.AddContent(6, 
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
            __builder2.AddContent(7, 
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
            __builder2.AddContent(8, "                        ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(9, "\n");
#nullable restore
#line 29 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatSelect\CoreMatSelectValue.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder2.AddContent(10, "            ");
            __builder2.CloseElement();
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
#pragma warning restore 1591
