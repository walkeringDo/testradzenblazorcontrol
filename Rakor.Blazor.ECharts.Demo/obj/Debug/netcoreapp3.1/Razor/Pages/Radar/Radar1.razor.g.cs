#pragma checksum "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Pages\Radar\Radar1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7abe19c816df3fa48c964f6e3dc2d258f9807fc"
// <auto-generated/>
#pragma warning disable 1591
namespace Demo.Pages.Radar
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Demo.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Demo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Container;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Button;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Dom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Dynamic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.NavMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Input;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Radio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Select;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.CheckBox;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Switch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Table;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Popup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Pagination;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Blazui.Component.Form;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\_Imports.razor"
using Rakor.Blazor.ECharts.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Pages\Radar\Radar1.razor"
using Rakor.Blazor.ECharts.Option;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Pages\Radar\Radar1.razor"
using Rakor.Blazor.ECharts.Option.Series;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/radar/radar1")]
    public partial class Radar1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenComponent<Rakor.Blazor.ECharts.Component.ECRadar>(2);
            __builder.AddAttribute(3, "Option", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Rakor.Blazor.ECharts.Option.EChartsOption<Rakor.Blazor.ECharts.Option.Series.Radar.Radar>>(
#nullable restore
#line 6 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Pages\Radar\Radar1.razor"
                      Option1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Class", "chart-fill");
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Pages\Radar\Radar1.razor"
      
    private EChartsOption<Rakor.Blazor.ECharts.Option.Series.Radar.Radar> Option1;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        Option1 = new EChartsOption<Rakor.Blazor.ECharts.Option.Series.Radar.Radar>()
        {
            Title=new Title() {Text="基础雷达图" },
            Tooltip=new Tooltip(),
            Legend=new Legend() {Data=new[] {"预算分配（Allocated Budget）", "实际开销（Actual Spending）" } },
            Radar=new Rakor.Blazor.ECharts.Option.Radar()
            {
                Name=new RadarName()
                {
                    TextStyle=new TextStyle()
                    {
                        Color="#fff",
                        BackgroundColor="#999",
                        BorderRadius=3,
                        Padding=new[] { 3,5}
                    }
                },
                Indicator=new List<RadarIndicator>()
                {
                    new RadarIndicator(){Name="销售（sales）",Max=6500 },
                    new RadarIndicator(){Name="管理（Administration）",Max=16000 },
                    new RadarIndicator(){Name="信息技术（Information Techology）",Max=30000 },
                    new RadarIndicator(){Name="客服（Customer Support）",Max=38000 },
                    new RadarIndicator(){Name="研发（Development）",Max=52000 },
                    new RadarIndicator(){Name="市场（Marketing）",Max=25000 },
                }
            },
            Series=new List<object>()
            {
                new Rakor.Blazor.ECharts.Option.Series.Radar.Radar()
                {
                    Name="预算 vs 开销（Budget vs spending）",
                    Data=new List<object>()
                    {
                        new SeriesData()
                        {
                            Name="预算分配（Allocated Budget）",
                            Value=new []{ 4300, 10000, 28000, 35000, 50000, 19000}
                        },
                        new SeriesData()
                        {
                            Name="实际开销（Actual Spending）",
                            Value=new []{ 5000, 14000, 28000, 31000, 42000, 21000}
                        }
                    }
                }
            }
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
