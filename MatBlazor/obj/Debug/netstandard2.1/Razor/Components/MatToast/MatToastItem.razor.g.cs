#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "636501c7190d1681ba7d84d28917d105d2a7511e"
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
    public partial class MatToastItem : BaseMatToastItem
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddContent(0, 
#nullable restore
#line 3 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
 Css

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(1, "\n\n");
            __builder.OpenComponent<MatBlazor.MatRipple>(2);
            __builder.AddAttribute(3, "Class", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
                   Class

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "style", 
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
                                  StyleMapper.AsString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
                                                               Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Attributes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.Object>>(
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
                                                                                Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "RefBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MatBlazor.ForwardRef>(
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
                                                                                                      RefBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", 
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
                 ContainerClassMapper.AsString()

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(11, "style", 
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
                                                          AnimationStyle

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
                                                                                    (_=>Clicked(_))

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "mat-toast-message");
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
             if (ShowProgressBar)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "mat-toast-progress");
                __builder2.AddAttribute(17, "style", 
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
                                                        ProgressBarStyle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 12 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
             if (!string.IsNullOrEmpty(Toast.Icon))
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MatBlazor.MatIcon>(18);
                __builder2.AddAttribute(19, "Class", "mat-toast-icon");
                __builder2.AddAttribute(20, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
                                                       Toast.Icon

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 16 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
             if (Toast.Options.ShowCloseButton)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MatBlazor.MatIconButton>(21);
                __builder2.AddAttribute(22, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
                                      Toast.Options.CloseIcon

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Class", "mat-toast-close-button");
                __builder2.AddAttribute(24, "OnMouseDown", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
                                                                                                            CloseIconClicked

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
#nullable restore
#line 20 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
             if (!string.IsNullOrEmpty(Message))
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "mat-toast-body");
#nullable restore
#line 25 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
                     if (!string.IsNullOrEmpty(Title))
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(27, "span");
                __builder2.AddAttribute(28, "class", "mat-toast-title");
                __builder2.AddContent(29, 
#nullable restore
#line 27 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
                                                       Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 28 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(30, 
#nullable restore
#line 29 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
                     Message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 31 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor\Components\MatToast\MatToastItem.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
