#pragma checksum "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\UpdateQuestionComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6009d818f1bb7f59422f7e5a23e281d477eb565c"
// <auto-generated/>
#pragma warning disable 1591
namespace Survey.Components.Questions
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
#line 1 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\UpdateQuestionComponent.razor"
using Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\UpdateQuestionComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class UpdateQuestionComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\UpdateQuestionComponent.razor"
                 OQuestion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-group");
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.AddMarkupContent(7, "<label>Pregunta:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(8);
                __builder2.AddAttribute(9, "class", "form-control");
                __builder2.AddAttribute(10, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\UpdateQuestionComponent.razor"
                                OQuestion.GetQuestion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => OQuestion.GetQuestion = __value, OQuestion.GetQuestion))));
                __builder2.AddAttribute(12, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => OQuestion.GetQuestion));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.AddMarkupContent(18, "<label>Referencia Categoria:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\UpdateQuestionComponent.razor"
                                OQuestion.CategoryId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => OQuestion.CategoryId = __value, OQuestion.CategoryId))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => OQuestion.CategoryId));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.AddMarkupContent(29, "<label>Referencia Encuesta:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\UpdateQuestionComponent.razor"
                                OQuestion.SurveyId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => OQuestion.SurveyId = __value, OQuestion.SurveyId))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => OQuestion.SurveyId));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.AddMarkupContent(40, "<label>Referencia Encuesta:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(41);
                __builder2.AddAttribute(42, "class", "form-control");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\UpdateQuestionComponent.razor"
                                OQuestion.UserId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => OQuestion.UserId = __value, OQuestion.UserId))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => OQuestion.UserId));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n    ");
                __builder2.OpenElement(48, "input");
                __builder2.AddAttribute(49, "type", "button");
                __builder2.AddAttribute(50, "class", "btn btn-success");
                __builder2.AddAttribute(51, "value", "Actualizar");
                __builder2.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\UpdateQuestionComponent.razor"
                                                                              SaveChangeQuestion

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\UpdateQuestionComponent.razor"
       
    [Parameter]
    public string id { get; set; }

    QuestionEntity OQuestion = new QuestionEntity();

    private void SaveChangeQuestion()
    {
        B_Questions.UpdateQuestions(OQuestion);
        NavManager.NavigateTo("question/list");
    }

    protected async override Task OnInitializedAsync()
    {
        OQuestion = B_Questions.QuestionsById(id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
