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
#nullable restore
#line 1 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoFileUpload.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoFileUpload.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public partial class DemoFileUpload : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoFileUpload.razor"
         
            List<string> list = new List<string>();

            void FilesReady(IMatFileUploadEntry[] files)
            {
                foreach (var file in files)
                {
                    list.Add($"Name: {file.Name} - Size: {file.Size}");
                }
            }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoFileUpload.razor"
          
            List<string> multiplelist = new List<string>();

            void MultipleFilesReady(IMatFileUploadEntry[] files)
            {
                foreach (var file in files)
                {
                    multiplelist.Add($"Name: {file.Name} - Size: {file.Size}");
                }
            } 
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "E:\c# project\Blazor\MatBlazor\MatBlazor-master\src\MatBlazor.Demo\Demo\DemoFileUpload.razor"
          
            string fileContent;

            async Task FilesReadyForContent(IMatFileUploadEntry[] files)
            {
                try
                {
                    var file = files.FirstOrDefault();
                    if (file == null)
                    {
                        return;
                    }

                    using (var stream = new MemoryStream())
                    {
                        var sw = Stopwatch.StartNew();
                        await file.WriteToStreamAsync(stream);
                        sw.Stop();
                        if (stream.Length > 1024 * 1024)
                        {
                            fileContent = "";
                            fileContent += $"Name:\t{file.Name}\r\n";
                            fileContent += $"Type:\t{file.Type}\r\n";
                            fileContent += $"LastModified:\t{file.LastModified}\r\n";
                            fileContent += $"Size:\t{file.Size}\r\n";
                            fileContent += $"Time:\t{sw.Elapsed}\r\n";
                            fileContent += $"Speed:\t{(stream.Length / sw.Elapsed.TotalSeconds):N0}  b/s\r\n";
                        }
                        else
                        {
                            stream.Seek(0, SeekOrigin.Begin);
                            using (var reader = new StreamReader(stream))
                            {
                                fileContent = await reader.ReadToEndAsync();
                            }
                        }
                    }
                }

                catch (Exception e)
                {
                    fileContent = $"Error:\r\n{e.Message}\r\n{e.StackTrace}";
                }
                finally
                {
                    await InvokeAsync(StateHasChanged);
                }
            }
        

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
