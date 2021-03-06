#pragma checksum "C:\estudo\Senac\Mod2\Uc07\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d44d84024640348ddd0a31d4a0ebd6e053dc8fcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_ListaDeUsuarios), @"mvc.1.0.view", @"/Views/Usuarios/ListaDeUsuarios.cshtml")]
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
#line 1 "C:\estudo\Senac\Mod2\Uc07\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\estudo\Senac\Mod2\Uc07\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d44d84024640348ddd0a31d4a0ebd6e053dc8fcd", @"/Views/Usuarios/ListaDeUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_ListaDeUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\estudo\Senac\Mod2\Uc07\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
  
    ViewData["Title"] = "Listagem de Livros";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <table class=""table table-striped""> 
            <thead>
                <tr><th>Nome</th>
                <th>Login</th>
                <th>Tipo</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 16 "C:\estudo\Senac\Mod2\Uc07\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
                 if(Model.Count==0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Nenhum resultado</td>\r\n");
#nullable restore
#line 18 "C:\estudo\Senac\Mod2\Uc07\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\estudo\Senac\Mod2\Uc07\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
                 foreach (Usuario u in Model)
                {
                    
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 24 "C:\estudo\Senac\Mod2\Uc07\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
                   Write(u.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\estudo\Senac\Mod2\Uc07\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
                   Write(u.login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 26 "C:\estudo\Senac\Mod2\Uc07\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
                     if(u.tipo==Usuario.ADMIN){

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <td>Administrador</td>  \r\n");
#nullable restore
#line 28 "C:\estudo\Senac\Mod2\Uc07\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
                    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>Padr??o</td> \r\n");
#nullable restore
#line 30 "C:\estudo\Senac\Mod2\Uc07\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 884, "\"", 913, 2);
            WriteAttributeValue("", 891, "editarUsuario?id=", 891, 17, true);
#nullable restore
#line 32 "C:\estudo\Senac\Mod2\Uc07\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 908, u.Id, 908, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">editar</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 958, "\"", 988, 2);
            WriteAttributeValue("", 965, "excluirUsuario?id=", 965, 18, true);
#nullable restore
#line 33 "C:\estudo\Senac\Mod2\Uc07\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 983, u.Id, 983, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">excluir</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "C:\estudo\Senac\Mod2\Uc07\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n        <a href=\"registrarUsuarios\">Registrar novo us??rio</a>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
