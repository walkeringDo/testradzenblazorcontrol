#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Shared\DemoDrawerContent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63ea5ae073329a13e3d836fc247099eafcb8710e"
// <auto-generated/>
#pragma warning disable 1591
namespace MatBlazor.Demo.Shared
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
#line 1 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Shared\DemoDrawerContent.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    public partial class DemoDrawerContent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .mdc-drawer {\r\n        box-shadow: 2px 0px 2px 0px rgba(199, 199, 199, 0.29);\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenComponent<MatBlazor.MatNavMenu>(1);
            __builder.AddAttribute(2, "Multi", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Shared\DemoDrawerContent.razor"
                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatNavItem>(4);
                __builder2.AddAttribute(5, "Href", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Shared\DemoDrawerContent.razor"
                       Url.ToAbsoluteUri("").AbsoluteUri

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "NavLinkMatch", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 10 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Shared\DemoDrawerContent.razor"
                                                                        NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatIcon>(8);
                    __builder3.AddAttribute(9, "Icon", "home");
                    __builder3.CloseComponent();
                    __builder3.AddContent(10, "  Home");
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 12 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Shared\DemoDrawerContent.razor"
     foreach (var groupModel in model)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MatBlazor.MatNavSubMenu>(11);
                __builder2.AddAttribute(12, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Shared\DemoDrawerContent.razor"
                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatNavSubMenuHeader>(14);
                    __builder3.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MatBlazor.MatNavItem>(16);
                        __builder4.AddAttribute(17, "AllowSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Shared\DemoDrawerContent.razor"
                                            false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(19, 
#nullable restore
#line 16 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Shared\DemoDrawerContent.razor"
                                                    groupModel.Group.Name

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n            ");
                    __builder3.OpenComponent<MatBlazor.MatNavSubMenuList>(21);
                    __builder3.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 19 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Shared\DemoDrawerContent.razor"
                 foreach (var navItem in groupModel.Items)
                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MatBlazor.MatNavItem>(23);
                        __builder4.AddAttribute(24, "Href", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Shared\DemoDrawerContent.razor"
                                       Url.ToAbsoluteUri(navItem.Url).AbsoluteUri

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(26, 
#nullable restore
#line 22 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Shared\DemoDrawerContent.razor"
                         navItem.Name

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 24 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Shared\DemoDrawerContent.razor"
                }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 27 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Shared\DemoDrawerContent.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Shared\DemoDrawerContent.razor"
 

    class NavItem
    {
        public NavGroup Group;
        public string Name;
        public string Url;
        public int Order;
    }

    class NavGroup
    {
        public string Name;
        public int Order;

        public NavGroup(string name, int order = int.MaxValue)
        {
            Name = name;
            Order = order;
        }
    }

    class NavGroupModel
    {
        public NavGroup Group;
        public NavItem[] Items;
    }

    NavGroupModel[] model;

    protected async override Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        var groups = new
        {
            FormControls = new NavGroup("Form Controls", 1),
            Navigation = new NavGroup("Navigation", 2),
            Layout = new NavGroup("Layout", 3),
            ButtonsAndIndicators = new NavGroup("Buttons & Indicators", 4),
            PopupsAndModals = new NavGroup("Popups & Modals", 5),
            DataTable = new NavGroup("Data Table", 6),
            Other = new NavGroup("Other", 10),
        };
        var navItems = new[]
        {
            new NavItem()
            {
                Name = "Validation via EditContext",
                Url = "EditContext",
                Group = groups.FormControls,
                Order = 1
            },
    //            new NavItem()
    //            {
    //                Name = "Autocomplete",
    //                Url = "Autocomplete",
    //                Group = groups.FormControls,
    //            },
            new NavItem()
            {
                Name = "AutocompleteList",
                Url = "AutocompleteList",
                Group = groups.FormControls,
            },
            new NavItem()
            {
                Name = "Checkbox",
                Url = "Checkbox",
                Group = groups.FormControls,
            },
            new NavItem()
            {
                Name = "TextField",
                Url = "TextField",
                Group = groups.FormControls,
            },
            new NavItem()
            {
                Name = "RadioButton",
                Url = "RadioButton",
                Group = groups.FormControls,
            },
            new NavItem()
            {
                Name = "Select",
                Url = "Select",
                Group = groups.FormControls,
            },
            new NavItem()
            {
                Name = "SelectItem",
                Url = "SelectItem",
                Group = groups.FormControls,
            },
            new NavItem()
            {
                Name = "SelectValue",
                Url = "SelectValue",
                Group = groups.FormControls,
            },
            new NavItem()
            {
                Name = "Slider",
                Url = "Slider",
                Group = groups.FormControls,
            },
            new NavItem()
            {
                Name = "SlideToggle",
                Url = "SlideToggle",
                Group = groups.FormControls,
            },
            new NavItem()
            {
                Name = "Drawer",
                Url = "Drawer",
                Group = groups.Navigation
            },
            new NavItem()
            {
                Name = "AppBar",
                Url = "AppBar",
                Group = groups.Navigation
            },
            new NavItem()
            {
                Name = "ButtonLink",
                Url = "ButtonLink",
                Group = groups.Navigation
            },
            new NavItem()
            {
                Name = "Dialog",
                Url = "Dialog",
                Group = groups.PopupsAndModals
            },
            new NavItem()
            {
                Name = "Snackbar",
                Url = "Snackbar",
                Group = groups.PopupsAndModals
            },
            new NavItem()
            {
                Name = "Menu",
                Url = "Menu",
                Group = groups.Layout
            },
            new NavItem()
            {
                Name = "Card",
                Url = "Card",
                Group = groups.Layout
            },
            new NavItem()
            {
                Name = "Divider",
                Url = "Divider",
                Group = groups.Layout
            },
            new NavItem()
            {
                Name = "List",
                Url = "List",
                Group = groups.Layout
            },
    // new NavItem()
    // {
    //     Name = "TreeView",
    //     Url = "TreeView",
    //     Group = groups.Layout
    // },
            new NavItem()
            {
                Name = "Button",
                Url = "Button",
                Group = groups.ButtonsAndIndicators
            },
            new NavItem()
            {
                Name = "Ripple",
                Url = "Ripple",
                Group = groups.ButtonsAndIndicators
            },
            new NavItem()
            {
                Name = "IconButton",
                Url = "IconButton",
                Group = groups.ButtonsAndIndicators
            },
            new NavItem()
            {
                Name = "Icon",
                Url = "Icon",
                Group = groups.ButtonsAndIndicators
            },
            new NavItem()
            {
                Name = "Chip",
                Url = "Chip",
                Group = groups.ButtonsAndIndicators
            },
            new NavItem()
            {
                Name = "ProgressBar",
                Url = "ProgressBar",
                Group = groups.ButtonsAndIndicators
            },
            new NavItem()
            {
                Name = "ProgressCircle",
                Url = "ProgressCircle",
                Group = groups.ButtonsAndIndicators
            },
            new NavItem()
            {
                Name = "Paper & Elevation",
                Url = "Paper",
                Group = groups.Layout
            },
            new NavItem()
            {
                Name = "Typography",
                Url = "Typography",
                Group = groups.Layout
            },
            new NavItem()
            {
                Name = "Layout Grid",
                Url = "LayoutGrid",
                Group = groups.Layout
            },
            new NavItem()
            {
                Name = "Tab",
                Url = "Tab",
                Group = groups.Layout
            },
            new NavItem()
            {
                Name = "DatePicker",
                Url = "DatePicker",
                Group = groups.FormControls
            },
            new NavItem()
            {
                Name = "FileUpload",
                Url = "FileUpload",
                Group = groups.FormControls
            },
            new NavItem()
            {
                Name = "Themes",
                Url = "Themes",
                Group = groups.Layout
            },
            new NavItem()
            {
                Name = "FAB",
                Url = "FAB",
                Group = groups.ButtonsAndIndicators
            },
            new NavItem()
            {
                Name = "Expansion Panel",
                Url = "ExpansionPanel",
                Group = groups.Layout
            },
            new NavItem()
            {
                Name = "Toast",
                Url = "Toast",
                Group = groups.PopupsAndModals
            },
            new NavItem()
            {
                Name = "Tooltip",
                Url = "Tooltip",
                Group = groups.PopupsAndModals
            },
            new NavItem()
            {
                Name = "Hidden",
                Url = "Hidden",
                Group = groups.Layout
            },
            new NavItem()
            {
                Name = "NumericUpDownField",
                Url = "NumericUpDownField",
                Group = groups.FormControls
            },
            new NavItem()
            {
                Name = "Nav Menu",
                Url = "NavMenu",
                Group = groups.Navigation
            },
            new NavItem()
            {
                Name = "Table",
                Url = "Table",
                Group = groups.DataTable
            },
            new NavItem()
            {
                Name = "Paginator",
                Url = "Paginator",
                Group = groups.DataTable
            },
            new NavItem()
            {
                Name = "SortHeader",
                Url = "SortHeader",
                Group = groups.DataTable
            },
            // new NavItem()
            // {
            //     Name = "DataTable",
            //     Url = "DataTable",
            //     Group = groups.DataTable
            // },
            new NavItem()
            {
                Name = "BaseComponent",
                Url = "BaseComponent",
                Group = groups.Other
            },
            new NavItem()
            {
                Name = "ForwardRef & RefBack",
                Url = "ForwardRef",
                Group = groups.Other
            },
            new NavItem()
            {
                Name = "Virtual Scroll",
                Url = "VirtualScroll",
                Group = groups.Layout
            },
            
            new NavItem()
            {
                Name = "ForwardRefContext",
                Url = "ForwardRefContext",
                Group = groups.Other
            },
            
            new NavItem()
            {
                Name = "DialogService",
                Url = "DialogService",
                Group = groups.PopupsAndModals
            },
    // new NavItem()
    // {
    //     Name = "Test",
    //     Url = "Test",
    //     Group = groups.Other
    // },
        };


        model = navItems
            .GroupBy(i => i.Group)
            .OrderBy(i => i.Key.Order)
            .ThenBy(i => i.Key.Name)
            .Select(g =>
            {
                return new NavGroupModel()
                {
                    Group = g.Key,
                    Items = g
                        .OrderBy(i => i.Order)
                        .ThenBy(i => i.Name)
                        .ToArray(),
                };
            })
            .ToArray();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Url { get; set; }
    }
}
#pragma warning restore 1591
