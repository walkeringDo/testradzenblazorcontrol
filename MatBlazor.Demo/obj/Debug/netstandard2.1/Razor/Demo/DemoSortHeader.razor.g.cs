#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoSortHeader.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "868d4d92b096138b973a5d00ece51f33dc372f5e"
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
#nullable restore
#line 1 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoSortHeader.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
    public partial class DemoSortHeader : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.Demo.Doc.DocMatSortHeader>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<MatBlazor.Demo.Doc.DocMatSortHeaderRow>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.AddMarkupContent(4, "<h5 class=\"mat-h5\">Example</h5>\n\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(5);
            __builder.AddAttribute(6, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(7, "table");
                __builder2.OpenComponent<MatBlazor.MatSortHeaderRow>(8);
                __builder2.AddAttribute(9, "Class", "demo-h-row");
                __builder2.AddAttribute(10, "SortChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MatBlazor.MatSortChangedEvent>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MatBlazor.MatSortChangedEvent>(this, 
#nullable restore
#line 10 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoSortHeader.razor"
                                                               SortData

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatSortHeader>(12);
                    __builder3.AddAttribute(13, "Class", "demo-h");
                    __builder3.AddAttribute(14, "SortId", "name");
                    __builder3.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(16, "Dessert (100g)");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(17, "\n                ");
                    __builder3.OpenComponent<MatBlazor.MatSortHeader>(18);
                    __builder3.AddAttribute(19, "Class", "demo-h");
                    __builder3.AddAttribute(20, "SortId", "calories");
                    __builder3.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(22, "Calories");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\n                ");
                    __builder3.OpenComponent<MatBlazor.MatSortHeader>(24);
                    __builder3.AddAttribute(25, "Class", "demo-h");
                    __builder3.AddAttribute(26, "SortId", "fat");
                    __builder3.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(28, "Fat (g)");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\n                ");
                    __builder3.OpenComponent<MatBlazor.MatSortHeader>(30);
                    __builder3.AddAttribute(31, "Class", "demo-h");
                    __builder3.AddAttribute(32, "SortId", "carbs");
                    __builder3.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(34, "Carbs (g)");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\n                ");
                    __builder3.OpenComponent<MatBlazor.MatSortHeader>(36);
                    __builder3.AddAttribute(37, "Class", "demo-h");
                    __builder3.AddAttribute(38, "SortId", "protein");
                    __builder3.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(40, "Protein (g)");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 18 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoSortHeader.razor"
             foreach (var dessert in sortedData)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(41, "tr");
                __builder2.OpenElement(42, "td");
                __builder2.AddContent(43, 
#nullable restore
#line 21 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoSortHeader.razor"
                         dessert.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\n                    ");
                __builder2.OpenElement(45, "td");
                __builder2.AddContent(46, 
#nullable restore
#line 22 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoSortHeader.razor"
                         dessert.Calories

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\n                    ");
                __builder2.OpenElement(48, "td");
                __builder2.AddContent(49, 
#nullable restore
#line 23 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoSortHeader.razor"
                         dessert.Fat

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\n                    ");
                __builder2.OpenElement(51, "td");
                __builder2.AddContent(52, 
#nullable restore
#line 24 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoSortHeader.razor"
                         dessert.Carbs

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\n                    ");
                __builder2.OpenElement(54, "td");
                __builder2.AddContent(55, 
#nullable restore
#line 25 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoSortHeader.razor"
                         dessert.Protein

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 27 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoSortHeader.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(56, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(57);
                __builder2.AddAttribute(58, "Template", "MatBlazor");
                __builder2.AddAttribute(59, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 102 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoSortHeader.razor"
                                                  @"
        <table>
            <MatSortHeaderRow Class=""demo-h-row"" SortChanged=""@SortData"">
                <MatSortHeader Class=""demo-h"" SortId=""name"">Dessert (100g)</MatSortHeader>
                <MatSortHeader Class=""demo-h"" SortId=""calories"">Calories</MatSortHeader>
                <MatSortHeader Class=""demo-h"" SortId=""fat"">Fat (g)</MatSortHeader>
                <MatSortHeader Class=""demo-h"" SortId=""carbs"">Carbs (g)</MatSortHeader>
                <MatSortHeader Class=""demo-h"" SortId=""protein"">Protein (g)</MatSortHeader>
            </MatSortHeaderRow>

            @foreach (var dessert in sortedData)
            {
                <tr>
                    <td>@dessert.Name</td>
                    <td>@dessert.Calories</td>
                    <td>@dessert.Fat</td>
                    <td>@dessert.Carbs</td>
                    <td>@dessert.Protein</td>
                </tr>
            }


        </table>

        @code
        {
            class Dessert
            {
                public int Calories { get; set; }
                public int Carbs { get; set; }
                public int Fat { get; set; }
                public string Name { get; set; }
                public int Protein { get; set; }
            }

            Dessert[] desserts = new[]
            {
                new Dessert() {Name = ""Frozen yogurt"", Calories = 159, Fat = 6, Carbs = 24, Protein = 4},
                new Dessert() {Name = ""Ice cream sandwich"", Calories = 237, Fat = 9, Carbs = 37, Protein = 4},
                new Dessert() {Name = ""Eclair"", Calories = 262, Fat = 16, Carbs = 24, Protein = 6},
                new Dessert() {Name = ""Cupcake"", Calories = 305, Fat = 4, Carbs = 67, Protein = 4},
                new Dessert() {Name = ""Gingerbread"", Calories = 356, Fat = 16, Carbs = 49, Protein = 4},
            };

            void SortData(MatSortChangedEvent sort)
            {
                sortedData = desserts.ToArray();
                if (!(sort == null || sort.Direction == MatSortDirection.None || string.IsNullOrEmpty(sort.SortId)))
                {
                    Comparison<Dessert> comparison = null;
                    switch (sort.SortId)
                    {
                        case ""name"":
                            comparison = (s1, s2) => string.Compare(s1.Name, s2.Name, StringComparison.InvariantCultureIgnoreCase);
                            break;
                        case ""calories"":
                            comparison = (s1, s2) => s1.Calories.CompareTo(s2.Calories);
                            break;
                        case ""fat"":
                            comparison = (s1, s2) => s1.Fat.CompareTo(s2.Fat);
                            break;
                        case ""carbs"":
                            comparison = (s1, s2) => s1.Carbs.CompareTo(s2.Carbs);
                            break;
                        case ""protein"":
                            comparison = (s1, s2) => s1.Protein.CompareTo(s2.Protein);
                            break;
                    }
                    if (comparison != null)
                    {
                        if (sort.Direction == MatSortDirection.Desc)
                        {
                            Array.Sort(sortedData, (s1, s2) => -1 * comparison(s1, s2));
                        }
                        else
                        {
                            Array.Sort(sortedData, comparison);
                        }

                    }
                }
            }

            Dessert[] sortedData = null;

            protected override void OnInitialized()
            {
                base.OnInitialized();
                SortData(null);
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
#line 33 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoSortHeader.razor"
         
            class Dessert
            {
                public int Calories { get; set; }
                public int Carbs { get; set; }
                public int Fat { get; set; }
                public string Name { get; set; }
                public int Protein { get; set; }
            }

            Dessert[] desserts = new[]
            {
                new Dessert() {Name = "Frozen yogurt", Calories = 159, Fat = 6, Carbs = 24, Protein = 4},
                new Dessert() {Name = "Ice cream sandwich", Calories = 237, Fat = 9, Carbs = 37, Protein = 4},
                new Dessert() {Name = "Eclair", Calories = 262, Fat = 16, Carbs = 24, Protein = 6},
                new Dessert() {Name = "Cupcake", Calories = 305, Fat = 4, Carbs = 67, Protein = 4},
                new Dessert() {Name = "Gingerbread", Calories = 356, Fat = 16, Carbs = 49, Protein = 4},
            };

            void SortData(MatSortChangedEvent sort)
            {
                sortedData = desserts.ToArray();
                if (!(sort == null || sort.Direction == MatSortDirection.None || string.IsNullOrEmpty(sort.SortId)))
                {
                    Comparison<Dessert> comparison = null;
                    switch (sort.SortId)
                    {
                        case "name":
                            comparison = (s1, s2) => string.Compare(s1.Name, s2.Name, StringComparison.InvariantCultureIgnoreCase);
                            break;
                        case "calories":
                            comparison = (s1, s2) => s1.Calories.CompareTo(s2.Calories);
                            break;
                        case "fat":
                            comparison = (s1, s2) => s1.Fat.CompareTo(s2.Fat);
                            break;
                        case "carbs":
                            comparison = (s1, s2) => s1.Carbs.CompareTo(s2.Carbs);
                            break;
                        case "protein":
                            comparison = (s1, s2) => s1.Protein.CompareTo(s2.Protein);
                            break;
                    }
                    if (comparison != null)
                    {
                        if (sort.Direction == MatSortDirection.Desc)
                        {
                            Array.Sort(sortedData, (s1, s2) => -1 * comparison(s1, s2));
                        }
                        else
                        {
                            Array.Sort(sortedData, comparison);
                        }

                    }
                }
            }

            Dessert[] sortedData = null;

            protected override void OnInitialized()
            {
                base.OnInitialized();
                SortData(null);
            }
        

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
