#pragma checksum "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9399bcc5059cdef66b7f4a7c2187938dc1519419"
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
#line 1 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
using Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class CreateQuestionsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-center h-2 mb-3 \">Crea Preguntas Con su Categoia, Encuesta y Usuario</h1>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, @"<div class=""container mb-3"">
    <div class=""row"">
        <div class=""col-6 col-sm-6 "">
            <a href=""question/list"" class=""btn btn-success"">Listar Preguntas... </a>
        </div>
        <div class=""col-6 col-sm-6 "">
            <a href=""answer/create"" class=""btn btn-success"">Crear Respuesta... </a>
        </div>
    </div>
</div>

");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-group");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<label>Categoria de La Preguntas: </label>\r\n    ");
            __builder.OpenElement(6, "select");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
                                            QuestionChange

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "option");
            __builder.AddAttribute(11, "value", true);
            __builder.AddContent(12, "Selecione...");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 21 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
         foreach (var category in Categorys)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "            ");
            __builder.OpenElement(15, "option");
            __builder.AddAttribute(16, "value", 
#nullable restore
#line 23 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
                            category.IdCategory

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " ");
            __builder.AddContent(18, 
#nullable restore
#line 23 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
                                                   category.NameCategory

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 24 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group");
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.AddMarkupContent(26, "<label>Identificador de La Encuesta: </label>\r\n    ");
            __builder.OpenElement(27, "select");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
                                            QuestionChangeUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "option");
            __builder.AddAttribute(32, "value", true);
            __builder.AddContent(33, "Selecione...");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 32 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
         foreach (var tempcategory in TempCategorys)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "            ");
            __builder.OpenElement(36, "option");
            __builder.AddAttribute(37, "value", 
#nullable restore
#line 34 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
                            tempcategory.SurveyId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(38, " ");
            __builder.AddContent(39, 
#nullable restore
#line 34 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
                                                     tempcategory.SurveyId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(40, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 35 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "form-group");
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.AddMarkupContent(48, "<label>Preguntas  Hecha Por:</label>\r\n    ");
            __builder.OpenElement(49, "select");
            __builder.AddAttribute(50, "class", "form-control");
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.OpenElement(52, "option");
            __builder.AddAttribute(53, "value", true);
            __builder.AddContent(54, "Selecione...");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 43 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
         foreach (var survey in TempSurveys)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "            ");
            __builder.OpenElement(57, "option");
            __builder.AddAttribute(58, "value", 
#nullable restore
#line 45 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
                            survey.UserId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(59, " ");
            __builder.AddContent(60, 
#nullable restore
#line 45 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
                                             survey.UserId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(61, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 46 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(66);
            __builder.AddAttribute(67, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 50 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
                 OQuestion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(69, "\r\n    ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group");
                __builder2.AddMarkupContent(72, "\r\n        ");
                __builder2.AddMarkupContent(73, "<label>Ingrese Identificador de Categoria:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(74);
                __builder2.AddAttribute(75, "class", "form-control");
                __builder2.AddAttribute(76, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
                                OQuestion.CategoryId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => OQuestion.CategoryId = __value, OQuestion.CategoryId))));
                __builder2.AddAttribute(78, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => OQuestion.CategoryId));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n    ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "container");
                __builder2.AddMarkupContent(83, "\r\n        ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "row");
                __builder2.AddMarkupContent(86, "\r\n            ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "col-6 col-sm-6");
                __builder2.AddMarkupContent(89, "\r\n                ");
                __builder2.AddMarkupContent(90, "<label>Ingrese Identificador de Usuario:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(91);
                __builder2.AddAttribute(92, "class", "form-control");
                __builder2.AddAttribute(93, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
                                        OQuestion.UserId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => OQuestion.UserId = __value, OQuestion.UserId))));
                __builder2.AddAttribute(95, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => OQuestion.UserId));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(96, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n            ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "col-6 col-sm-6");
                __builder2.AddMarkupContent(100, "\r\n                ");
                __builder2.AddMarkupContent(101, "<label>Ingrese Identificador de La Encuesta:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(102);
                __builder2.AddAttribute(103, "class", "form-control");
                __builder2.AddAttribute(104, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
                                        OQuestion.SurveyId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(105, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => OQuestion.SurveyId = __value, OQuestion.SurveyId))));
                __builder2.AddAttribute(106, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => OQuestion.SurveyId));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(107, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n    ");
                __builder2.OpenElement(111, "div");
                __builder2.AddAttribute(112, "class", "form-group");
                __builder2.AddMarkupContent(113, "\r\n        ");
                __builder2.AddMarkupContent(114, "<label>Identificador :</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(115);
                __builder2.AddAttribute(116, "class", "form-control");
                __builder2.AddAttribute(117, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 69 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
                                OQuestion.IdQuestions

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(118, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => OQuestion.IdQuestions = __value, OQuestion.IdQuestions))));
                __builder2.AddAttribute(119, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => OQuestion.IdQuestions));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(120, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n    ");
                __builder2.OpenElement(122, "div");
                __builder2.AddAttribute(123, "class", "form-group");
                __builder2.AddMarkupContent(124, "\r\n        ");
                __builder2.AddMarkupContent(125, "<label>Pregunta 1:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(126);
                __builder2.AddAttribute(127, "class", "form-control");
                __builder2.AddAttribute(128, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 73 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
                                OQuestion.GetQuestion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(129, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => OQuestion.GetQuestion = __value, OQuestion.GetQuestion))));
                __builder2.AddAttribute(130, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => OQuestion.GetQuestion));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(131, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n    ");
                __builder2.OpenElement(133, "input");
                __builder2.AddAttribute(134, "type", "button");
                __builder2.AddAttribute(135, "class", "btn btn-success");
                __builder2.AddAttribute(136, "value", "Crear Pregunta");
                __builder2.AddAttribute(137, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
                                                                                  SaveQuestions

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\yenny\Desktop\Portafolio\Asp .net Blazor\Survey\Components\Questions\CreateQuestionsComponent.razor"
       
    private string message = "";
    QuestionEntity OQuestion = new QuestionEntity();
    List<CategoryEntity> Categorys = new List<CategoryEntity>();
    List<CategoryEntity> TempCategorys = new List<CategoryEntity>();
    List<SurveyEntity> Surveys = new List<SurveyEntity>();
    List<SurveyEntity> TempSurveys = new List<SurveyEntity>();

    protected override async Task OnInitializedAsync()
    {
        
        Categorys = B_Categories.CategoriesList();
        Surveys = B_Surey.SureyList();
        TempCategorys = Categorys;
        TempSurveys = Surveys;
    }

    private void SaveQuestions()
    {
        OQuestion.CreateAt = DateTime.Now;
        B_Questions.CreateQuestions(OQuestion);
    }

    private void QuestionChange(ChangeEventArgs eventArgs)
    {
        //message = eventArgs.Value.ToString();
        TempCategorys = Categorys.Where(c => c.SurveyId == eventArgs.Value.ToString()).ToList();

    }
    private void QuestionChangeUser(ChangeEventArgs eventArgs)
    {

        TempSurveys = Surveys.Where(c => c.UserId == eventArgs.Value.ToString()).ToList();

    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
