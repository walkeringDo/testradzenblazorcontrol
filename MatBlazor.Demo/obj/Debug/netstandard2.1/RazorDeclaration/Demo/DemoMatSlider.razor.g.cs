// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class DemoMatSlider : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatSlider.razor"
         

            public decimal Val
            {
                get => _val;
                set
                {
                    _val = value;
                    this.StateHasChanged();
                }
            }

            private decimal _val = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatSlider.razor"
         

            public decimal Val2
            {
                get => _val2;
                set
                {
                    _val2 = value;
                    this.StateHasChanged();
                }
            }

            private decimal _val2 = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatSlider.razor"
         

            public int Val3
            {
                get => _val3;
                set
                {
                    _val3 = value;
                    this.StateHasChanged();
                }
            }

            private int _val3 = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 151 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatSlider.razor"
         

            public int Val4
            {
                get => _val4;
                set
                {
                    _val4 = value;
                    this.StateHasChanged();
                }
            }

            private int _val4 = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 199 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatSlider.razor"
         

            public int Val5
            {
                get => _val5;
                set
                {
                    _val5 = value;
                    this.StateHasChanged();
                }
            }

            private int _val5 = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 259 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatSlider.razor"
         

            public void OnValueChanged(decimal val)
            {
                Console.WriteLine($"OnValueChanged: {val}");
            }

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 296 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoMatSlider.razor"
         

            public decimal Value { get; set; } = 50;
            public decimal ValueMin { get; set; } = 0;
            public decimal ValueMax { get; set; } = 100;

            public void OnValueChanged2(decimal val)
            {
                Value = val;
            }

        

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
