using Microsoft.AspNetCore.Mvc;
using Sistema_de_Mercado;

namespace SistemaDeMercado.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProdutoController : ControllerBase
    {
        private IRepositorio _repositorio;
        public ProdutoController(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }


        [HttpGet]
        public ActionResult <List<Produto>> ObterTodos()
        {
            return Ok();
        }


    }
}
