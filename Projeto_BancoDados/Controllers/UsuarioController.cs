using Microsoft.AspNetCore.Mvc;
using Projeto_BancoDados.Models;
using Projeto_BancoDados.Repositório;
using Projeto_BancoDados.Repositório.Contrato;

namespace Projeto_BancoDados.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioRepository _usuariorepository;

        public UsuarioController(IUsuarioRepository usuariorepository)
        {
            _usuariorepository = usuariorepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CadastrarUsuario()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarUsuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _usuariorepository.CadastrarUsuario(usuario);

            }
            return RedirectToAction(nameof(Index));
        }
    }
}