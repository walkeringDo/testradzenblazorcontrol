#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e164971438e457d89c05b7000a295b85c6844948"
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
    public partial class MatDataTableOld<TItem> : BaseMatDataTableOld<TItem>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
  
    var visibleItems = GetVisibleItems();
    var renderedItems = GetRenderedItems(visibleItems);
    var scrollResult = VirtualScrollHelper.GetResult(renderedItems, 52, 56, StickyHeader);

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
             ClassMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                                             StyleMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "id", 
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                                                                                      Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddMultipleAttributes(4, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                                                                                                        Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(5, (__value) => {
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                                                                            Ref = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __Blazor.MatBlazor.MatDataTableOld.TypeInference.CreateCascadingValue_0(__builder, 6, 7, 
#nullable restore
#line 13 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                            this

#line default
#line hidden
#nullable disable
            , 8, (__builder2) => {
                __builder2.AddContent(9, 
#nullable restore
#line 14 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
         Columns

#line default
#line hidden
#nullable disable
                );
            }
            );
            __builder.AddMarkupContent(10, "\n\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "mat-data-table-container");
            __builder.AddAttribute(13, "style", 
#nullable restore
#line 17 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                                                   scrollResult.ScrollContainerStyle

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "class", "mdc-data-table__table");
            __builder.OpenComponent<MatBlazor.MatDataTableHeaderOld>(16);
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 20 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                 foreach (var column in columnItems)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MatBlazor.MatDataTableHeaderCellOld>(18);
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 23 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                         if (column.HeaderTemplate != null)
                        {
                            

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(20, 
#nullable restore
#line 25 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                             column.HeaderTemplate

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 25 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                                                  
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(21, 
#nullable restore
#line 29 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                             column.Header

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 29 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                                          
                        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 32 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\n\n            ");
            __builder.OpenComponent<MatBlazor.MatDataTableContentOld>(23);
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 37 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                 foreach (var item in renderedItems.Skip(scrollResult.SkipItems).Take(scrollResult.TakeItems))
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MatBlazor.MatDataTableRowOld>(25);
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 40 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                         foreach (var column in columnItems)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MatBlazor.MatDataTableCellOld>(27);
                    __builder3.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 43 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                                 if (column.Template != null)
                                {
                                    

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(29, 
#nullable restore
#line 45 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                                     column.Template(item)

#line default
#line hidden
#nullable disable
                        );
#nullable restore
#line 45 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                                                          
                                }
                                else if (@column.Value != null)
                                {
                                    

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(30, 
#nullable restore
#line 49 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                                     column.Value(item)

#line default
#line hidden
#nullable disable
                        );
#nullable restore
#line 49 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                                                       
                                }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 52 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 55 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
     if (Paginator)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MatBlazor.MatPaginator>(31);
            __builder.AddAttribute(32, "PageSizeOptions", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IReadOnlyList<MatBlazor.MatPageSizeOption>>(
#nullable restore
#line 62 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                                        PageSizeOptions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 62 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                                                                    PageSize

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "PageLabel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                                                                                          PageLabel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "Length", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 62 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                                                                                                              visibleItems.Count()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "Page", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MatBlazor.MatPaginatorPageEvent>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MatBlazor.MatPaginatorPageEvent>(this, 
#nullable restore
#line 62 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
                                                                                                                                           OnPageHandler

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 63 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatDataTableOld\MatDataTableOld.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.MatBlazor.MatDataTableOld
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
    }
}
#pragma warning restore 1591
