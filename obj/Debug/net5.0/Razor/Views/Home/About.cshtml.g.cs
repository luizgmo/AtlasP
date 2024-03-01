#pragma checksum "C:\Users\etec\Downloads\AtlasP\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4acee28d415e435397ed289888cbf14a59602e8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\etec\Downloads\AtlasP\Views\_ViewImports.cshtml"
using AtlasP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\etec\Downloads\AtlasP\Views\_ViewImports.cshtml"
using AtlasP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4acee28d415e435397ed289888cbf14a59602e8c", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0e24b4ba95fa178185d2387e97b4da64c5774ee", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\etec\Downloads\AtlasP\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  <!-- Breadcrumb Section Begin -->
    <section class=""breadcrumb-section set-bg spad"" data-setbg=""../img/foto-cabeçalho.jpg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-text"">
                        <h2>Sobre Nós</h2>
                        <div class=""breadcrumb-controls"">
                            <a><i class=""fa fa-home""></i> Início</a>
                            <span>Sobre Nós</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Breadcrumb End -->

    <!-- Aboutus Section Begin -->
    <section class=""aboutus-section spad"">
        <div class=""container"">
            <div class=""aboutus-page-text"">
                    <div class=""row"">
                        <div class=""col-xl-9 col-lg-10 m-auto"">
                        <div class=""section-title"">
                            <");
            WriteLiteral(@"h2>Academia Atlas</h2>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-8"">
                        <div class=""about-us"">
                            <h4>SOBRE NÓS</h4>
                            <p>Somos uma academia com um conceito de saúde em primeiro lugar, trabalhamos a 
                                individualidade como principal foco em  nossas prescrições de treinamento e 
                                reabilitação.
                            </p>
                            <p>Com o nosso trabalho, os clientes alcançam os melhores resultados e recebem
                                toda a atenção dos profissionais da área. A academia contém toda infraestrutura
                                necessária para a realização de seu treino. Nosso objetivo é transformar a 
                                vida das pessoas de forma geral, ou seja, tanto promovendo resultados físicos");
            WriteLiteral(@"
                                na prática dos exercícios propostos pelo profissional, tanto promovendo uma
                                interação entre as pessoas do ambiente, fornecendo experiências saudáveis.
                            </p>
                            <p>Nossa equipe conta com profissionais especializados, competentes, dedicados e
                                apaixonados no serviço que oferecem. Também realizam o trabalho com muito
                                respeito, honestidade, transparência, ética, responsabilidade e comprometimento.
                            </p>    
                        </div>
                    </div>
                    <div class=""col-lg-4"">
                        <div class=""about-quality"">
                            <h4>NOSSAS CARACTERÍSTICAS</h4>
                            <ul>
                                <li><i class=""fa fa-check-circle-o""></i>Saúde e bem-estar em primeiro lugar</li>
                                <li><");
            WriteLiteral(@"i class=""fa fa-check-circle-o""></i>Ótimo relacionamento com o cliente</li>
                                <li><i class=""fa fa-check-circle-o""></i>Preocupação com o cliente</li>
                                <li><i class=""fa fa-check-circle-o""></i>Ambiente agradável</li>
                                <li><i class=""fa fa-check-circle-o""></i>Profissionais excelentes</li>
                                <li><i class=""fa fa-check-circle-o""></i>Boa localização</li>
                                <li><i class=""fa fa-check-circle-o""></i>Qualidade de gestão</li>
                                <li><i class=""fa fa-check-circle-o""></i>Equipamentos tecnológicos</li>
                                <li><i class=""fa fa-check-circle-o""></i>Resultados</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Aboutus Section End -->

    

    <!-- Trainer Section Begin -->
    <sec");
            WriteLiteral(@"tion class=""trainer-section spad"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""section-title"">
                        <h2>Nossos Treinadores</h2>
                        <p>Nosso treinador profissional e preparado para auxiliar e orientar novos integrantes.</p>
                    </div>
                </div>
            </div>
            <div class=""row"">

");
#nullable restore
#line 93 "C:\Users\etec\Downloads\AtlasP\Views\Home\About.cshtml"
             foreach (var coach in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-3 col-sm-6\">\r\n                    <div class=\"trainer-item\">\r\n                        <div class=\"ti-pic\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 4837, "\"", 4855, 1);
#nullable restore
#line 98 "C:\Users\etec\Downloads\AtlasP\Views\Home\About.cshtml"
WriteAttributeValue("", 4843, coach.Image, 4843, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4856, "\"", 4862, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"trainer-text\">\r\n                                <h5>");
#nullable restore
#line 100 "C:\Users\etec\Downloads\AtlasP\Views\Home\About.cshtml"
                               Write(coach.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>- ");
#nullable restore
#line 100 "C:\Users\etec\Downloads\AtlasP\Views\Home\About.cshtml"
                                                   Write(coach.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 105 "C:\Users\etec\Downloads\AtlasP\Views\Home\About.cshtml"
            }    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                
            </div>
        </div>
    </section>
    <!-- Trainer Section End -->

    <!-- Cta Section Begin -->
    <section class=""cta-section"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""cta-text"">
                        <h3>Comece hoje!</h3>
                        <p>Cuide de sua saúde com os melhores profissionais.</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Cta Section End -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
