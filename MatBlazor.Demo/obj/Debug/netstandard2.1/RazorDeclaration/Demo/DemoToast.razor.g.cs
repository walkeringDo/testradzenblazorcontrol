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
    public partial class DemoToast : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 150 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoToast.razor"
               
            private string _title = "Test Title";
            private string _message = "Test Message";
            private bool _showProgressBar;
            private bool _showCloseButton;
            private bool _actionOnClick;
            private string _maximumOpacity;

            private string _showTransitionDuration;
            private string _visibleStateDuration;
            private string _hideTransitionDuration;

            private bool _requireInteraction;

            public string _maxDisplayedToasts
            {
                get { return Toaster.Configuration.MaxDisplayedToasts.ToString(); }
                set { Toaster.Configuration.MaxDisplayedToasts = Convert.ToInt32(value); }
            }


            string _toastPosition
            {
                get { return Toaster.Configuration.Position.ToString(); }
                set { Toaster.Configuration.Position = (MatToastPosition)Enum.Parse(typeof(MatToastPosition), value); }
            }

            protected override void OnInitialized()
            {
                _showProgressBar = Toaster.Configuration.ShowProgressBar;
                _showCloseButton = Toaster.Configuration.ShowCloseButton;
                _maximumOpacity = Toaster.Configuration.MaximumOpacity.ToString();

                _showTransitionDuration = Toaster.Configuration.ShowTransitionDuration.ToString();
                _visibleStateDuration = Toaster.Configuration.VisibleStateDuration.ToString();
                _hideTransitionDuration = Toaster.Configuration.HideTransitionDuration.ToString();

                _requireInteraction = Toaster.Configuration.RequireInteraction;
            }

            public void Show(MatToastType type, string icon = "")
            {
                Toaster.Add(_message, type, _title, icon, config =>
                {
                    config.ShowCloseButton = _showCloseButton;
                    config.ShowProgressBar = _showProgressBar;
                    config.MaximumOpacity = Convert.ToInt32(_maximumOpacity);

                    config.ShowTransitionDuration = Convert.ToInt32(_showTransitionDuration);
                    config.VisibleStateDuration = Convert.ToInt32(_visibleStateDuration);
                    config.HideTransitionDuration = Convert.ToInt32(_hideTransitionDuration);

                    config.RequireInteraction = _requireInteraction;

                    if (_actionOnClick)
                    {
                        config.Onclick = toast =>
                        {
                            Console.WriteLine($"Title: \"{toast.Title}\"; message: \"{toast.Message}\"; Type: {toast.Options.Type}");
                            return Task.CompletedTask;
                        };
                    }
                });
            }

        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
    }
}
#pragma warning restore 1591
