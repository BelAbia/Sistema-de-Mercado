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
        public IActionResult ObterTodos()
        {
            try
            {
                var obterTodosProdutos = _repositorio.ObterTodos;
                return Ok(obterTodosProdutos);
            }
            catch
            {
                throw new Exception("Erro ao obter todos");
            }
            
        }

        [HttpGet("{Id}")]
        public IActionResult ObterPorId(int Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var obterPorId = _repositorio.ObterPorId(Id);
            return Ok(obterPorId);
        }

        [HttpPost]
        public IActionResult AdicionarProduto(Produto produto)
        {
            _repositorio.AdicionarProduto(produto);
            return CreatedAtAction("Adicionando produto", produto);
        }

        [HttpDelete("{Id}")]
        public IActionResult DeletarProduto(int Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var ProdutoASerDeletado = _repositorio.ObterPorId(Id);
            _repositorio.DeletarProduto(ProdutoASerDeletado.Id);

            return NoContent();
        }

        [HttpPut("{Id}")]
        public IActionResult AtualizarProduto(Produto produto)
        {
            if (produto == null)
            {
                return NotFound();
            }

            _repositorio.AtualizarProduto(produto);

            return NoContent();
        }
    }
}