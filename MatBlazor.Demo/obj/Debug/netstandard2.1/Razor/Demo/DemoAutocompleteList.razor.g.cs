#pragma checksum "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbe2dd38f3e0863ed8da4773cdfba83462e7d5de"
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
    public partial class DemoAutocompleteList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.Demo.Doc.DocMatAutocompleteList>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n\n\n");
            __builder.AddMarkupContent(2, "<h5 class=\"mat-h5\">Example</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(3);
            __builder.AddAttribute(4, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatAutocompleteList<string>>(5);
                __builder2.AddAttribute(6, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<string>>(
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                     options

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "Label", "Pick one");
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(8, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(9);
                __builder2.AddAttribute(10, "Template", "MatBlazor");
                __builder2.AddAttribute(11, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                                  @"
        <MatAutocompleteList Items=""@options"" TItem=""string"" Label=""Pick one""></MatAutocompleteList>

        @code
        {

            string[] options = new[]
            {
                ""One"",
                ""Two"",
                ""Three""
            };

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
            __builder.AddMarkupContent(12, "\n\n");
            __builder.AddMarkupContent(13, "<h5 class=\"mat-h5\">Icon</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(14);
            __builder.AddAttribute(15, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatAutocompleteList<string>>(16);
                __builder2.AddAttribute(17, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<string>>(
#nullable restore
#line 45 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                     options

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Icon", "thumb_up_alt");
                __builder2.AddAttribute(19, "Label", "Pick one");
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(20, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(21);
                __builder2.AddAttribute(22, "Template", "MatBlazor");
                __builder2.AddAttribute(23, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                                  @"
        <MatAutocompleteList Items=""@options"" Icon=""thumb_up_alt"" TItem=""string"" Label=""Pick one""></MatAutocompleteList>
    "

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\n\n");
            __builder.AddMarkupContent(25, "<h5 class=\"mat-h5\">Clear Button</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(26);
            __builder.AddAttribute(27, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatAutocompleteList<string>>(28);
                __builder2.AddAttribute(29, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<string>>(
#nullable restore
#line 57 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                     options

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 57 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                                      options[0]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ShowClearButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 57 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "Icon", "thumb_up_alt");
                __builder2.AddAttribute(33, "Label", "Pick one");
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(34, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(35);
                __builder2.AddAttribute(36, "Template", "MatBlazor");
                __builder2.AddAttribute(37, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                                  @"
        <MatAutocompleteList Items=""@options"" Value=""@options[0]"" ShowClearButton=""true"" Icon=""thumb_up_alt"" TItem=""string"" Label=""Pick one""></MatAutocompleteList>
    "

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\n\n");
            __builder.AddMarkupContent(39, "<h5 class=\"mat-h5\">ItemTemplate</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(40);
            __builder.AddAttribute(41, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(42, "p");
                __builder2.OpenComponent<MatBlazor.MatAutocompleteList<Car>>(43);
                __builder2.AddAttribute(44, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Car>>(
#nullable restore
#line 70 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                         options2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "Label", "Select car");
                __builder2.AddAttribute(46, "CustomStringSelector", new System.Func<Car, System.String>(
#nullable restore
#line 70 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                                                                                          i => i.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Car>(
#nullable restore
#line 70 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                                                                                                                      value

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Car>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Car>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => value = __value, value))));
                __builder2.AddAttribute(49, "ItemTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Car>)((context) => (__builder3) => {
                    __builder3.OpenElement(50, "div");
                    __builder3.AddAttribute(51, "style", "display: flex; flex-direction: row; width: 100%;");
                    __builder3.OpenElement(52, "div");
                    __builder3.AddAttribute(53, "style", "flex: 1;");
                    __builder3.AddContent(54, 
#nullable restore
#line 73 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                               context.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(55, "\n                        ");
                    __builder3.OpenElement(56, "div");
                    __builder3.AddAttribute(57, "style", "width: 150px;");
                    __builder3.AddContent(58, 
#nullable restore
#line 74 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                                    context.Price

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(59, "$");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\n        ");
                __builder2.OpenElement(61, "p");
                __builder2.AddMarkupContent(62, "\n            Selected value: ");
                __builder2.AddContent(63, 
#nullable restore
#line 80 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                              value?.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(64, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(65);
                __builder2.AddAttribute(66, "Template", "MatBlazor");
                __builder2.AddAttribute(67, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 115 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                                  @"
        <p>
            <MatAutocompleteList Items=""@options2"" TItem=""Car"" Label=""Select car"" CustomStringSelector=""@(i => i.Name)"" @bind-Value=""@value"">
                <ItemTemplate>
                    <div style=""display: flex; flex-direction: row; width: 100%;"">
                        <div style=""flex: 1;"">@context.Name</div>
                        <div style=""width: 150px;"">@context.Price$</div>
                    </div>
                </ItemTemplate>
            </MatAutocompleteList>
        </p>
        <p>
            Selected value: @(value?.Name)
        </p>

        @code
        {

            public class Car
            {
                public string Name { get; set; }
                public double Price { get; set; }

                public Car(string name, double price)
                {
                    Name = name;
                    Price = price;
                }
            }

            Car value = null;

            Car[] options2 = new[]
            {
                new Car(""Volkswagen Golf"", 10000),
                new Car(""Volkswagen Passat"", 11000),
                new Car(""Volkswagen Polo"", 12000),
                new Car(""Ford Focus"", 13000),
                new Car(""Ford Fiesta"", 14000),
                new Car(""Ford Fusion"", 15000),
                new Car(""Ford Mondeo"", 16000),
            };

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
            __builder.AddMarkupContent(68, "\n\n\n");
            __builder.AddMarkupContent(69, "<h5 class=\"mat-h5\">With Full Width</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(70);
            __builder.AddAttribute(71, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatAutocompleteList<Car>>(72);
                __builder2.AddAttribute(73, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Car>>(
#nullable restore
#line 168 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                     options2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "FullWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 168 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "Label", "Select car");
                __builder2.AddAttribute(76, "CustomStringSelector", new System.Func<Car, System.String>(
#nullable restore
#line 168 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                                                                                                       i => i.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ItemTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Car>)((context) => (__builder3) => {
                    __builder3.OpenElement(78, "div");
                    __builder3.AddAttribute(79, "style", "display: flex; flex-direction: row; width: 100%;");
                    __builder3.OpenElement(80, "div");
                    __builder3.AddAttribute(81, "style", "flex: 1;");
                    __builder3.AddContent(82, 
#nullable restore
#line 171 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                           context.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(83, "\n                    ");
                    __builder3.OpenElement(84, "div");
                    __builder3.AddAttribute(85, "style", "width: 150px;");
                    __builder3.AddContent(86, 
#nullable restore
#line 172 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                                context.Price

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(87, "$");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(88, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(89);
                __builder2.AddAttribute(90, "Template", "MatBlazor");
                __builder2.AddAttribute(91, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 178 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                                  @"
        <MatAutocompleteList Items=""@options2"" FullWidth=""true"" TItem=""Car"" Label=""Select car"" CustomStringSelector=""@(i => i.Name)"">
            <ItemTemplate>
                <div style=""display: flex; flex-direction: row; width: 100%;"">
                    <div style=""flex: 1;"">@context.Name</div>
                    <div style=""width: 150px;"">@context.Price$</div>
                </div>
            </ItemTemplate>
        </MatAutocompleteList>
    "

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(92, "\n\n");
            __builder.AddMarkupContent(93, "<h5 class=\"mat-h5\">In an edit form with a Data Annotation Validator</h5>\n");
            __builder.OpenComponent<MatBlazor.Demo.DemoContainer.DemoContainer>(94);
            __builder.AddAttribute(95, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(96);
                __builder2.AddAttribute(97, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 194 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                          model

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(98, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 194 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                                HandleValidSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(100);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(101, "\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(102);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(103, "\n            ");
                    __builder3.OpenComponent<MatBlazor.MatAutocompleteList<string>>(104);
                    __builder3.AddAttribute(105, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<string>>(
#nullable restore
#line 197 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                         model.Options

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(106, "Icon", "thumb_up_alt");
                    __builder3.AddAttribute(107, "Label", "Pick one(Required)");
                    __builder3.AddAttribute(108, "ShowClearButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 197 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                                                                                                                                                           true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(109, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 197 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                                                                                         model.SelectedOption

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(110, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.SelectedOption = __value, model.SelectedOption))));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(111, "\n            ");
                    __builder3.OpenComponent<MatBlazor.MatButton>(112);
                    __builder3.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(114, "Submit");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(115, "SourceContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.Demo.BlazorFiddle.BlazorFiddle>(116);
                __builder2.AddAttribute(117, "Template", "MatBlazor");
                __builder2.AddAttribute(118, "Code", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 218 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
                                                  @"
        <EditForm Model=""@model"" OnValidSubmit=""HandleValidSubmit"">
            <DataAnnotationsValidator />
            <ValidationSummary />
            <MatAutocompleteList Items=""@model.Options"" Icon=""thumb_up_alt"" TItem=""string"" @bind-Value=""@model.SelectedOption"" Label=""Pick one(Required)"" ShowClearButton=""true""></MatAutocompleteList>
            <MatButton>Submit</MatButton>
        </EditForm>
        @code
        {
            class AutocompleteContextModel
            {
                public List<string> Options { get; set; } = new List<string>() { ""A test option"", ""Another test option"", ""One more option"" };

                [System.ComponentModel.DataAnnotations.Required]
                public string SelectedOption { get; set; }
            }
            AutocompleteContextModel model = new AutocompleteContextModel();

            void HandleValidSubmit()
            {
                Console.WriteLine(""On Valid Submit"");
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
#line 10 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
         

            string[] options = new[]
            {
                "One",
                "Two",
                "Three"
            };

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
         

            public class Car
            {
                public string Name { get; set; }
                public double Price { get; set; }

                public Car(string name, double price)
                {
                    Name = name;
                    Price = price;
                }
            }

            Car value = null;

            Car[] options2 = new[]
            {
                new Car("Volkswagen Golf", 10000),
                new Car("Volkswagen Passat", 11000),
                new Car("Volkswagen Polo", 12000),
                new Car("Ford Focus", 13000),
                new Car("Ford Fiesta", 14000),
                new Car("Ford Fusion", 15000),
                new Car("Ford Mondeo", 16000),
            };

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 201 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoAutocompleteList.razor"
         
            class AutocompleteContextModel
            {
                public List<string> Options { get; set; } = new List<string>() { "A test option", "Another test option", "One more option" };

                [System.ComponentModel.DataAnnotations.Required]
                public string SelectedOption { get; set; }
            }
            AutocompleteContextModel model = new AutocompleteContextModel();

            void HandleValidSubmit()
            {
                Console.WriteLine("On Valid Submit");
            }
        

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
