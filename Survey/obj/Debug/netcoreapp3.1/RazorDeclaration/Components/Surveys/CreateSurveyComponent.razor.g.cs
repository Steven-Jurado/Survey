// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Survey.Components.Surveys
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\_Imports.razor"
using Survey;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\_Imports.razor"
using Survey.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\_Imports.razor"
using Survey.Components.Surveys;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\_Imports.razor"
using Survey.Components.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\_Imports.razor"
using Survey.Components.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\_Imports.razor"
using Survey.Components.Questions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\_Imports.razor"
using Survey.Components.Answer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Surveys\CreateSurveyComponent.razor"
using Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Surveys\CreateSurveyComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class CreateSurveyComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Surveys\CreateSurveyComponent.razor"
       
    private string message = "";
    SurveyEntity OSurvey = new SurveyEntity();
    List<UserEntity> Users = new List<UserEntity>();

    protected override async Task OnInitializedAsync()
    {
        Users = B_Users.UsersList();
    }

    private void SaveSurvey()
    {

        OSurvey.CreateAt = DateTime.Now;
        OSurvey.DateEnd = DateTime.Now;
        B_Surey.CreateSurey(OSurvey);
        message = "Encuesta Creada";
        NavManager.NavigateTo("survey/list");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
