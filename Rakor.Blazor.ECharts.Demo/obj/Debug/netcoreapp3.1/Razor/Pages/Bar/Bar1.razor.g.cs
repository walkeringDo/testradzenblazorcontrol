#pragma checksum "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Pages\Bar\Bar1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b8fc4f3bdfe6a06881e29ac21e9db151eeef33c"
// <auto-generated/>
#pragma warning disable 1591
namespace Demo.Pages.Bar
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
#line 2 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Pages\Bar\Bar1.razor"
using Rakor.Blazor.ECharts.Option;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Pages\Bar\Bar1.razor"
using Rakor.Blazor.ECharts.Option.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Pages\Bar\Bar1.razor"
using Rakor.Blazor.ECharts.Option.Series.Bar;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bar/bar1")]
    public partial class Bar1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenComponent<Rakor.Blazor.ECharts.Component.ECBar>(2);
            __builder.AddAttribute(3, "Option", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Rakor.Blazor.ECharts.Option.EChartsOption<Rakor.Blazor.ECharts.Option.Series.Bar.Bar>>(
#nullable restore
#line 7 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Pages\Bar\Bar1.razor"
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
#line 10 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Pages\Bar\Bar1.razor"
      
    private EChartsOption<Bar> Option1;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        Option1 = new EChartsOption<Bar>()
        {
            Color = new[] { "#8EC9EB" },
            Legend = new Legend() { Data = "高度(km)与气温(°C)变化关系" },
            Tooltip = new Tooltip()
            {
                Trigger = TooltipTrigger.Axis,
                Formatter = "Temperature : <br/>{b}km : {c}°C"
            },
            Grid = new List<Grid>()
            {
                new Grid(){Left="3%",Right="4%",Bottom="3%",ContainLabel=true}
            },
            XAxis=new List<XAxis>()
            {
                new XAxis(){ Type=AxisType.Value,SplitLine=new SplitLine(){Show=false },AxisLabel=new AxisLabel(){Formatter="{value} °C" } }
            },
            YAxis=new List<YAxis>()
            {
                new YAxis(){Type=AxisType.Category,AxisLine=new AxisLine(){OnZero=false },AxisLabel=new AxisLabel(){Formatter="{value} km" },BoundaryGap=true,Data=new []{"0", "10", "20",  "30", "40", "50", "60", "70", "80" } }
            },
            Series=new List<object>()
            {
                new Bar()
                {
                    Name="高度(km)与气温(°C)变化关系",
                    Smooth=true,
                    BarCategoryGap=25,
                    LineStyle=new {normal=new {width=3,shadowColor="rgba(0,0,0,0.4)",shadowBlur=10,shadowOffsetY=10 } },
                    Data=new []{ 15, -50, -56.5, -46.5, -22.1, -2.5, -27.7, -55.7, -76.5}
                }
            },
            Graphic=new List<object>()
            {
                new GraphicImage()
                {
                    Id="logo",
                    Right=20,
                    Top=20,
                    Z=-10,
                    Bounding="raw",
                    Style=new GraphicStyle()
                    {
                        Image="http://echarts.baidu.com/images/favicon.png",
                        Width=150,
                        Height=150,
                        Opacity=0.4
                    }
                },
                new GraphicGroup()
                {
                    Rotation=Math.PI/4,
                    Bounding="raw",
                    Right=110,
                    Bottom=110,
                    Z=100,
                    Children=new List<object>()
                    {
                        new
                        {
                            type= "rect",
                            left= "center",
                            top= "center",
                            z= 100,
                            shape=new {
                                width= 400,
                                height= 50
                            },
                            style=new {
                                fill="rgba(0,0,0,0.3)"
                            }
                        },
                        new
                        {
                            type= "text",
                            left= "center",
                            top= "center",
                            z= 100,
                            style=new {
                                fill= "#fff",
                                text= "ECHARTS BAR CHART",
                                font= "bold 26px Microsoft YaHei"
                            }
                        }
                    }
                },
                new GraphicGroup()
                {
                    Left="10%",
                    Top="center",
                    Children=new List<object>()
                    {
                        new
                        {
                            type= "rect",
                            z= 100,
                            left= "center",
                            top= "middle",
                            shape=new {
                                width= 190,
                                height= 90
                            },
                            style=new {
                                fill= "#fff",
                                stroke= "#555",
                                lineWidth= 2,
                                shadowBlur= 8,
                                shadowOffsetX= 3,
                                shadowOffsetY= 3,
                                shadowColor= "rgba(0,0,0,0.3)"
                            }
                        },
                        new
                        {
                            type= "text",
                            z= 100,
                            left= "center",
                            top= "middle",
                            style=new {
                                fill= "#333",
                                text=string.Join("\n",new []{
                                    "横轴表示温度，单位是°C",
                                    "纵轴表示高度，单位是km",
                                    "右上角有一个图片做的水印",
                                    "这个文本块可以放在图中各",
                                    "种位置"
                                }),
                                font= "14px Microsoft YaHei"
                            }
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