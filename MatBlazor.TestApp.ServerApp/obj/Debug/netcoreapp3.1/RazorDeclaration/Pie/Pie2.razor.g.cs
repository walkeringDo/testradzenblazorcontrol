// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MatBlazor.TestApp.ServerApp.Pie
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using MatBlazor.TestApp.ServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using MatBlazor.TestApp.ServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using MatBlazor.TestApp.ServerApp.TestMetaComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Container;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Button;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Dom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Dynamic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.NavMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Input;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Radio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Select;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.CheckBox;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Switch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Table;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Popup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Pagination;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Blazui.Component.Form;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\_Imports.razor"
using Rakor.Blazor.ECharts.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\Pie\Pie2.razor"
using Rakor.Blazor.ECharts.Option;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\Pie\Pie2.razor"
using Rakor.Blazor.ECharts.Option.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\Pie\Pie2.razor"
using Rakor.Blazor.ECharts.Option.Series.Pie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\Pie\Pie2.razor"
using Rakor.Blazor.ECharts.Option.Series;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pie/pie2")]
    public partial class Pie2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "E:\c# project\Blazor\MatBlazor-master\src\MatBlazor.TestApp.ServerApp\Pie\Pie2.razor"
      
    private EChartsOption<Pie> Option1;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        Option1 = new EChartsOption<Pie>()
        {
            Title=new Title()
            {
                Text="天气情况统计",
                Subtext="虚构数据",
                Left="center"
            },
            Tooltip=new Tooltip()
            {
                Trigger=TooltipTrigger.Item,
                Formatter="{a} <br/>{b} : {c} ({d}%)"
            },
            Legend=new Legend()
            {
                Bottom=10,
                Left="center",
                Data=new[] { "西凉", "益州", "兖州", "荆州", "幽州"}
            },
            Series=new List<object>()
            {
                new Pie()
                {
                    Radius="65%",
                    Center=new []{"50%", "50%" },
                    SelectedMode=SelectedMode.Single,
                    Emphasis=new Emphasis()
                    {
                        ItemStyle=new ItemStyle()
                        {
                            ShadowBlur=10,
                            ShadowOffsetX=0,
                            ShadowColor="rgba(0, 0, 0, 0.5)"
                        }
                    },
                    Data=new List<object>()
                    {
                        new SeriesData()
                        {
                            Name="幽州",
                            Value=1548,
                            Label=new Label()
                            {
                                Formatter=string.Join("\n",new []{"{title|{b}}{abg|}","  {weatherHead|天气}{valueHead|天数}{rateHead|占比}","{hr|}","  {sunny|}{value|202}{rate|55.3%}","  {cloudy|}{value|142}{rate|38.9%}","  {showers|}{value|21}{rate|5.8%}" }),
                                BackgroundColor="#eee",
                                BorderColor="#777",
                                BorderWidth=1,
                                BorderRadius=4,
                                Rich=new
                                {
                                    title=new Label{Color="#eee",Align=Align2.Center },
                                    abg=new Label{BackgroundColor="#333",Width="100%",Align=Align2.Right,Height=25,BorderRadius=new []{ 4,4,0,0,} },
                                    sunny=new Label(){Height=30,Align=Align2.Left,BackgroundColor=new {image="https://www.echartsjs.com/data/asset/img/weather/sunny_128.png" } },
                                    cloudy=new Label(){Height=30,Align=Align2.Left,BackgroundColor=new {image="https://www.echartsjs.com/data/asset/img/weather/cloudy_128.png" } },
                                    showers=new Label(){Height=30,Align=Align2.Left,BackgroundColor=new {image="https://www.echartsjs.com/data/asset/img/weather/showers_128.png" } },
                                    weatherHead=new Label(){Color="#333",Height=24,Align=Align2.Left },
                                    hr=new Label(){BorderColor="#777",Width="100%",BorderWidth=0.5,Height=0 },
                                    value=new Label(){Width=20,Align=Align2.Left,Padding=new []{ 0,20,0,30} },
                                    valueHead=new Label(){Color="#333",Width=20,Align=Align2.Center,Padding=new []{ 0,20,0,30} },
                                    rate=new Label(){Width=40,Align=Align2.Right,Padding=new []{ 0,10,0,0} },
                                    rateHead=new Label(){Color="#333",Width=40,Align=Align2.Center,Padding=new []{ 0,10,0,0} }
                                }
                            }
                        },
                        new SeriesData(){ Name="荆州",Value=535},
                        new SeriesData(){ Name="兖州",Value=510},
                        new SeriesData(){ Name="益州",Value=634},
                        new SeriesData(){ Name="西凉",Value=735},
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
