// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Demo.Pages.Candlestick
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
#line 2 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Pages\Candlestick\Candlestick2.razor"
using Rakor.Blazor.ECharts.Option;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Pages\Candlestick\Candlestick2.razor"
using Rakor.Blazor.ECharts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Pages\Candlestick\Candlestick2.razor"
using Rakor.Blazor.ECharts.Option.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Pages\Candlestick\Candlestick2.razor"
using Rakor.Blazor.ECharts.Option.Series.Candlestick;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Pages\Candlestick\Candlestick2.razor"
using Rakor.Blazor.ECharts.Option.Series.Line;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Pages\Candlestick\Candlestick2.razor"
using Rakor.Blazor.ECharts.Option.Series.Bar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Pages\Candlestick\Candlestick2.razor"
using Rakor.Blazor.ECharts.Option.Series;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/k/k2")]
    public partial class Candlestick2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "E:\c# project\Blazor\BlazorECharts-master\Rakor.Blazor.ECharts.Demo\Pages\Candlestick\Candlestick2.razor"
      
    private EChartsOption<object> Option1;
    private ECandlestick k;

    private void ShowData(string code, DateTime? start, DateTime? end)
    {
        if (code.StartsWith("0")) code = "sh." + code;
        else code = "sz." + code;
        if (start == null && end == null)
        {
            end = yesterday;
            start = yesterday.AddYears(-1);
        }
        else if (start == null)
        {
            start = end.Value.AddYears(-1);
        }
        else if (end == null)
        {
            end = start.Value.AddYears(1);
        }
        else
        {
            if (end.Value.Subtract(start.Value).TotalDays > 365)
            {
                Message.Show("时间跨度不能大于一年", MessageType.Error);
                return;
            }
        }
        string ip = "172.19.54.106";
#if DEBUG
        ip = "101.132.118.176";
#endif
        var info=Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockInfo>>(HttpClient.GetStringAsync($"http://{ip}:8124/api/info/{code}").Result).FirstOrDefault();
        if (info == null)
        {
            Message.Show("未获取到指数信息，请确认代码是否正确。", MessageType.Error);
            return;
        }
        if (info.Type != 2)
        {
            Message.Show($"该代码所代表的【{info.Name}】不是指数。", MessageType.Error);
            return;
        }
        _=k.ShowLoadingAsync();
        var result = HttpClient.GetStringAsync($"http://{ip}:8124/api/kindex/{code}/{start.Value.ToString("yyyy-MM-dd")}/{end.Value.ToString("yyyy-MM-dd")}").Result;
        var stock = Newtonsoft.Json.JsonConvert.DeserializeObject<List<StockData>>(result);
        var category = stock.Select(item => item.Date);
        var values = stock.Select(item => new[] { item.Open, item.Close, item.Low, item.High, item.Amount });
        var values1 = values.ToList();
        var volumes = stock.Select((item, index) => new[] { index, item.Amount, item.Close >= item.Open ? 1 : -1 });
        string upColor = "#ec0000", downColor = "#00da3c";

        Option1 = new EChartsOption<object>()
        {
            Title = new Title() { Text = $"【{info.Name}】K线图" },
            BackgroundColor = "#fff",
            Animation = false,
            Legend = new Legend()
            {
                Left = "center",
                Data = new[] { "指数信息", "MA5", "MA10", "MA20", "MA30" }
            },
            Tooltip = new Tooltip()
            {
                Trigger = TooltipTrigger.Axis,
                AxisPointer = new TooltipAxisPointer() { Type = AxisPointerType.Cross }
            },
            Grid = new List<Grid>()
{
                new Grid(){Left="10%",Right="8%",Height="70%" },
                new Grid(){Left="10%",Right="8%",Top="78%",Height="16%" }
            },
            XAxis = new List<XAxis>()
{
                new XAxis()
                {
                    Type=AxisType.Category,
                    Data=category,
                    Scale=true,
                    BoundaryGap=false,
                    AxisLine=new AxisLine(){ OnZero=false},
                    SplitLine=new SplitLine(){ Show=false},
                    SplitNumber=20,
                    Min="dataMin",
                    Max="dataMax"
                },
                new XAxis()
                {
                    Type=AxisType.Category,
                    GridIndex=1,
                    Data=category,
                    Scale=true,
                    BoundaryGap=false,
                    AxisLine=new AxisLine(){ OnZero=false},
                    AxisTick=new AxisTick(){Show=false },
                    SplitLine=new SplitLine(){ Show=false},
                    AxisLabel=new AxisLabel(){ Show=false},
                    SplitNumber=20,
                    Min="dataMin",
                    Max="dataMax"
                }
            },
            YAxis = new List<YAxis>()
{
                new YAxis()
                {
                    Scale=true,
                    SplitArea=new SplitArea(){ Show=true}
                },
                new YAxis()
                {
                    Scale=true,
                    GridIndex=1,
                    SplitNumber=2,
                    AxisLabel=new AxisLabel(){ Show=false},
                    AxisLine=new AxisLine(){ Show=false},
                    AxisTick=new AxisTick(){ Show=false},
                    SplitLine=new SplitLine(){ Show=false},
                }
            },
            DataZoom = new List<object>()
{
                new DataZoomInside()
                {
                    XAxisIndex=new []{0,1 },
                    Start=70,
                    End=100
                },
                new DataZoomSlider()
                {
                    Show=true,
                    XAxisIndex=new []{0,1 },
                    Top="95%",
                    Start=70,
                    End=100
                }
            },
            Series = new List<object>()
    {
                new Candlestick()
                {
                    Name="指数信息",
                    Data=values,
                    ItemStyle=new ItemStyle(){Color=upColor,Color0=downColor,BorderColor="null".ToJRaw(),BorderColor0="null".ToJRaw() },
                    MarkPoint=new MarkPoint()
                    {
                        Label=new Label(){Formatter="function (param) {return param != null ? Math.round(param.value) : '';}".ToJRaw() },
                        Data=new List<MarkPointData>()
                        {
                            new MarkPointData()
                            {
                                Name="最高点",
                                Type=MarkPointDataType.Max,
                                ValueDim="highest"
                            },
                            new MarkPointData()
                            {
                                Name="最低点",
                                Type=MarkPointDataType.Min,
                                ValueDim="lowest"
                            },
                            new MarkPointData()
                            {
                                Name="平均值",
                                Type=MarkPointDataType.Average,
                                ValueDim="close"
                            }
                        },
                        Tooltip=new Tooltip(){Formatter="function (param) {return param.name + '<br>' + (param.data.coord || '');}".ToJRaw() }
                    },
                    MarkLine=new MarkLine()
                    {
                        Symbol=new []{ "none","none"},
                        Data=new List<object>()
                        {
                            new List<MarkLineData>()
                            {
                                new MarkLineData()
                                {
                                    Name="高低点连线",
                                    Type=Sampling.Min,
                                    ValueDim="lowest",
                                    Symbol="circle",
                                    SymbolSize=10,
                                    Label=new MarkLineDataLabel(){Show=false },
                                    Emphasis=new Emphasis(){ Show=false}
                                },
                                new MarkLineData()
                                {
                                    Type=Sampling.Max,
                                    ValueDim="highest",
                                    Symbol="circle",
                                    SymbolSize=10,
                                    Label=new MarkLineDataLabel(){Show=false },
                                    Emphasis=new Emphasis(){ Show=false}
                                }
                            },
                            new MarkLineData()
                            {
                                Name="最小值",
                                Type=Sampling.Min,
                                ValueDim="close"
                            },
                            new MarkLineData()
                            {
                                Name="最大值",
                                Type=Sampling.Max,
                                ValueDim="close"
                            }
                        }
                    }
                },
                new Line()
                {
                    Name="MA5",
                    Data=CalculateMA(5,values1),
                    Smooth=true,
                    LineStyle=new LineStyle(){Opacity=0.5 }
                },
                new Line()
                {
                    Name="MA10",
                    Data=CalculateMA(10,values1),
                    Smooth=true,
                    LineStyle=new LineStyle(){Opacity=0.5 }
                },
                new Line()
                {
                    Name="MA20",
                    Data=CalculateMA(20,values1),
                    Smooth=true,
                    LineStyle=new LineStyle(){Opacity=0.5 }
                },
                new Line()
                {
                    Name="MA30",
                    Data=CalculateMA(30,values1),
                    Smooth=true,
                    LineStyle=new LineStyle(){Opacity=0.5 }
                },
                new Bar()
                {
                    Name="成交额",
                    XAxisIndex=1,
                    YAxisIndex=1,
                    Data=volumes
                }
            }
        };

        _ = k.SetupOptionAsync(Option1, true);
    }

    protected override void OnAfterRender(bool firstRender)
    {
        if (IsFirst) Submit();
        IsFirst = false;
    }

    private List<object> CalculateMA(int day, List<double[]> data)
    {
        List<object> list = new List<object>();
        for (int i = 0, count = data.Count(); i < count; i++)
        {
            if (i < day)
            {
                list.Add("-");
                continue;
            }
            double sum = 0;
            for (int j = 0; j < day; j++)
            {
                sum += data[i - j][1];
            }
            list.Add(Math.Round(sum / day, 3));
        }
        return list;
    }

    protected BForm demoForm;
    private bool IsFirst = true;
    internal KDemoFormModel value;
    DateTime yesterday = DateTime.Now.AddDays(-1);
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        value = new KDemoFormModel()
        {
            Code = "000001",
            StartTime = yesterday.AddYears(-1),
            EndTime = yesterday
        };
    }
    protected void Submit()
    {
        if (!demoForm.IsValid())
        {
            return;
        }
        var model = demoForm.GetValue<KDemoFormModel>();
        ShowData(model.Code, model.StartTime, model.EndTime);
    }
    protected void Reset()
    {
        demoForm.Reset();
        Submit();
    }
    public class KDemoFormModel
    {
        public string Code { set; get; }
        public DateTime? StartTime { set; get; }
        public DateTime? EndTime { set; get; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MessageService Message { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591