#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f74ee81c3741c3525c73984df415e665d70b23a"
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
#line 1 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatList.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    public partial class DemoMatList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.Demo.Doc.DocMatList>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<MatBlazor.Demo.Doc.DocMatListItem>(2);
            __builder.AddAttribute(3, "Secondary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatList.razor"
                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n\n");
            __builder.AddMarkupContent(5, "<h5 class=\"mat-h5\">\n    Example\n</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(6);
            __builder.AddAttribute(7, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatList>(8);
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatListItem>(10);
                    __builder3.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(12, "\n                Item 1\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(13, "\n            ");
                    __builder3.OpenComponent<MatBlazor.MatListItem>(14);
                    __builder3.AddAttribute(15, "Href", "#");
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(17, "\n                Item 2\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\n            ");
                    __builder3.OpenComponent<MatBlazor.MatListItem>(19);
                    __builder3.AddAttribute(20, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatList.razor"
                                   true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Href", "#");
                    __builder3.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(23, "\n                Item 3 - Disabled\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(24, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(25);
                __builder2.AddAttribute(26, "Template", "MatBlazor");
                __builder2.AddAttribute(27, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatList.razor"
                                                  @"
        <MatList>
            <MatListItem>
                Item 1
            </MatListItem>
            <MatListItem Href=""#"">
                Item 2
            </MatListItem>
            <MatListItem Disabled=""true"" Href=""#"">
                Item 3 - Disabled
            </MatListItem>
        </MatList>
    "

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\n\n");
            __builder.AddMarkupContent(29, "<h5 class=\"mat-h5\">SingleSelection</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(30);
            __builder.AddAttribute(31, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatList>(32);
                __builder2.AddAttribute(33, "SingleSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatList.razor"
                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatListItem>(35);
                    __builder3.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(37, "\n                Item 1\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\n            ");
                    __builder3.OpenComponent<MatBlazor.MatListItem>(39);
                    __builder3.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(41, "\n                Item 2\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\n            ");
                    __builder3.OpenComponent<MatBlazor.MatListItem>(43);
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(45, "\n                Item 3\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(46, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(47);
                __builder2.AddAttribute(48, "Template", "MatBlazor");
                __builder2.AddAttribute(49, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatList.razor"
                                                  @"
        <MatList SingleSelection=""true"">
            <MatListItem>
                Item 1
            </MatListItem>
            <MatListItem>
                Item 2
            </MatListItem>
            <MatListItem>
                Item 3
            </MatListItem>
        </MatList>
    "

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\n\n");
            __builder.AddMarkupContent(51, "<h5 class=\"mat-h5\">\n    Two-Line List\n</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(52);
            __builder.AddAttribute(53, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatList>(54);
                __builder2.AddAttribute(55, "SingleSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 77 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatList.razor"
                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "TwoLine", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 77 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatList.razor"
                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatListItem>(58);
                    __builder3.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MatBlazor.MatListItemText>(60);
                        __builder4.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MatBlazor.MatListItemPrimaryText>(62);
                            __builder5.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(64, "First-line text");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(65, "\n                    ");
                            __builder5.OpenComponent<MatBlazor.MatListItemSecondaryText>(66);
                            __builder5.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(68, "Second-line text");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\n\n            ");
                    __builder3.OpenComponent<MatBlazor.MatListItem>(70);
                    __builder3.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MatBlazor.MatListItemText>(72);
                        __builder4.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MatBlazor.MatListItemPrimaryText>(74);
                            __builder5.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(76, "First-line text");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(77, "\n                    ");
                            __builder5.OpenComponent<MatBlazor.MatListItemSecondaryText>(78);
                            __builder5.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(80, "Second-line text");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(81, "\n\n            ");
                    __builder3.OpenComponent<MatBlazor.MatListItem>(82);
                    __builder3.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MatBlazor.MatListItemText>(84);
                        __builder4.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MatBlazor.MatListItemPrimaryText>(86);
                            __builder5.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(88, "First-line text");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(89, "\n                    ");
                            __builder5.OpenComponent<MatBlazor.MatListItemSecondaryText>(90);
                            __builder5.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(92, "Second-line text");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(93, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(94);
                __builder2.AddAttribute(95, "Template", "MatBlazor");
                __builder2.AddAttribute(96, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 102 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatList.razor"
                                                  @"
        <MatList SingleSelection=""true"" TwoLine=""true"">
            <MatListItem>
                <MatListItemText>
                    <MatListItemPrimaryText>First-line text</MatListItemPrimaryText>
                    <MatListItemSecondaryText>Second-line text</MatListItemSecondaryText>
                </MatListItemText>
            </MatListItem>

            <MatListItem>
                <MatListItemText>
                    <MatListItemPrimaryText>First-line text</MatListItemPrimaryText>
                    <MatListItemSecondaryText>Second-line text</MatListItemSecondaryText>
                </MatListItemText>
            </MatListItem>

            <MatListItem>
                <MatListItemText>
                    <MatListItemPrimaryText>First-line text</MatListItemPrimaryText>
                    <MatListItemSecondaryText>Second-line text</MatListItemSecondaryText>
                </MatListItemText>
            </MatListItem>

        </MatList>
    "

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(97, "\n\n");
            __builder.AddMarkupContent(98, "<h5 class=\"mat-h5\">\n    MatListGroup\n</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(99);
            __builder.AddAttribute(100, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatListGroup>(101);
                __builder2.AddAttribute(102, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatListGroupSubHeader>(103);
                    __builder3.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(105, "List 1");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(106, "\n            ");
                    __builder3.OpenComponent<MatBlazor.MatList>(107);
                    __builder3.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MatBlazor.MatListItem>(109);
                        __builder4.AddAttribute(110, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(111, "\n                    line item\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(112, "\n                ");
                        __builder4.OpenComponent<MatBlazor.MatListItem>(113);
                        __builder4.AddAttribute(114, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(115, "\n                    line item\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(116, "\n            ");
                    __builder3.OpenComponent<MatBlazor.MatListGroupSubHeader>(117);
                    __builder3.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(119, "List 2");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(120, "\n            ");
                    __builder3.OpenComponent<MatBlazor.MatList>(121);
                    __builder3.AddAttribute(122, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MatBlazor.MatListItem>(123);
                        __builder4.AddAttribute(124, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(125, "\n                    line item\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(126, "\n                ");
                        __builder4.OpenComponent<MatBlazor.MatListItem>(127);
                        __builder4.AddAttribute(128, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(129, "\n                    line item\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(130, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(131);
                __builder2.AddAttribute(132, "Template", "MatBlazor");
                __builder2.AddAttribute(133, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 157 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatList.razor"
                                                  @"
        <MatListGroup>
            <MatListGroupSubHeader>List 1</MatListGroupSubHeader>
            <MatList>
                <MatListItem>
                    line item
                </MatListItem>
                <MatListItem>
                    line item
                </MatListItem>
            </MatList>
            <MatListGroupSubHeader>List 2</MatListGroupSubHeader>
            <MatList>
                <MatListItem>
                    line item
                </MatListItem>
                <MatListItem>
                    line item
                </MatListItem>
            </MatList>
        </MatListGroup>
    "

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(134, "\n\n");
            __builder.AddMarkupContent(135, "<h5 class=\"mat-h5\">\n    MatListDivider\n</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(136);
            __builder.AddAttribute(137, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatList>(138);
                __builder2.AddAttribute(139, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatListItem>(140);
                    __builder3.AddAttribute(141, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(142, "\n                line item\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(143, "\n            ");
                    __builder3.OpenComponent<MatBlazor.MatListDivider>(144);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(145, "\n            ");
                    __builder3.OpenComponent<MatBlazor.MatListItem>(146);
                    __builder3.AddAttribute(147, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(148, "\n                line item\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(149, "\n            ");
                    __builder3.OpenComponent<MatBlazor.MatListDivider>(150);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(151, "\n            ");
                    __builder3.OpenComponent<MatBlazor.MatListItem>(152);
                    __builder3.AddAttribute(153, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(154, "\n                line item\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(155, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(156);
                __builder2.AddAttribute(157, "Template", "MatBlazor");
                __builder2.AddAttribute(158, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 202 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatList.razor"
                                                  @"
        <MatList>
            <MatListItem>
                line item
            </MatListItem>
            <MatListDivider></MatListDivider>
            <MatListItem>
                line item
            </MatListItem>
            <MatListDivider></MatListDivider>
            <MatListItem>
                line item
            </MatListItem>
        </MatList>
    "

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(159, "\n\n");
            __builder.AddMarkupContent(160, "<h5 class=\"mat-h5\">\n    MatListItem Href\n</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(161);
            __builder.AddAttribute(162, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatList>(163);
                __builder2.AddAttribute(164, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatListItem>(165);
                    __builder3.AddAttribute(166, "Href", "http://google.com");
                    __builder3.AddAttribute(167, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(168, "\n                Google\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(169, "\n            ");
                    __builder3.OpenComponent<MatBlazor.MatListItem>(170);
                    __builder3.AddAttribute(171, "Href", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 230 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatList.razor"
                                Url.ToAbsoluteUri("MatTextField").AbsoluteUri

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(172, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(173, "\n                MatTextField\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(174, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(175);
                __builder2.AddAttribute(176, "Template", "MatBlazor");
                __builder2.AddAttribute(177, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 236 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatList.razor"
                                                  @"
        @inject NavigationManager Url
        <MatList>
            <MatListItem Href=""http://google.com"">
                Google
            </MatListItem>
            <MatListItem Href=""@Url.ToAbsoluteUri(""MatTextField"").AbsoluteUri"">
                MatTextField
            </MatListItem>
        </MatList>
    "

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(178, "\n\n\n");
            __builder.AddMarkupContent(179, "<h4 class=\"mat-h4\">Helper components</h4>\n");
            __builder.AddMarkupContent(180, "<h5 class=\"mat-h5\">MatListItemText</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(181);
            __builder.AddAttribute(182, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatList>(183);
                __builder2.AddAttribute(184, "SingleSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 255 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatList.razor"
                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(185, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatListItem>(186);
                    __builder3.AddAttribute(187, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MatBlazor.MatListItemText>(188);
                        __builder4.AddAttribute(189, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(190, "\n                    Item 1\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(191, "\n            ");
                    __builder3.OpenComponent<MatBlazor.MatListItem>(192);
                    __builder3.AddAttribute(193, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MatBlazor.MatListItemText>(194);
                        __builder4.AddAttribute(195, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(196, "\n                    Item 2\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(197, "\n            ");
                    __builder3.OpenComponent<MatBlazor.MatListItem>(198);
                    __builder3.AddAttribute(199, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MatBlazor.MatListItemText>(200);
                        __builder4.AddAttribute(201, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(202, "\n                    Item 3\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(203, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(204);
                __builder2.AddAttribute(205, "Template", "MatBlazor");
                __builder2.AddAttribute(206, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 274 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatList.razor"
                                                  @"
        <MatList SingleSelection=""true"">
            <MatListItem>
                <MatListItemText>
                    Item 1
                </MatListItemText>
            </MatListItem>
            <MatListItem>
                <MatListItemText>
                    Item 2
                </MatListItemText>
            </MatListItem>
            <MatListItem>
                <MatListItemText>
                    Item 3
                </MatListItemText>
            </MatListItem>
        </MatList>
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Url { get; set; }
    }
}
#pragma warning restore 1591