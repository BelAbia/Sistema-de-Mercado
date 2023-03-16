using Dominio;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_Mercado;

namespace SistemaDeMercado.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProdutoController : ControllerBase
    {
        Validacao validacao = new();
        MensagensDeErro mensagensDeErro = new();
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
                var ListaDeProdutos = _repositorio.ObterTodos();
                return Ok(ListaDeProdutos);
            }
            catch
            {
                throw new Exception(mensagensDeErro.ErroParaObterListaDeProdutos);
            }
        }

        [HttpGet("{Id}")]
        public IActionResult ObterPorId(int Id)
        {
            try
            {
                if (Id == 0)
                {
                    return NotFound();
                }

                var produto = _repositorio.ObterPorId(Id);
                return Ok(produto);
            }
            catch
            {
                throw new Exception(mensagensDeErro.ErroParaObterProdutoPorId(Id));
            }
        }

        [HttpPost]
        public IActionResult AdicionarProduto(Produto produto)
        {
            try
            {
                if (produto == null)
                {
                    return BadRequest();
                }

                validacao.Validar(produto);
                _repositorio.AdicionarProduto(produto);
                return Created("sucesso", produto);

            }catch(Exception e) 
            {
                throw new Exception(e.Message);
            }
        }

        [HttpDelete("{Id}")]
        public IActionResult DeletarProduto(int Id)
        {
            try
            {
                if (Id == 0)
                {
                    return NotFound();
                }

                var ProdutoASerDeletado = _repositorio.ObterPorId(Id);
                _repositorio.DeletarProduto(ProdutoASerDeletado.Id);
                return NoContent();
            }
            catch
            {
                throw new Exception(mensagensDeErro.ErroParaDeletarProduto);
            }
        }

        [HttpPut("{Id}")]
        public IActionResult AtualizarProduto(Produto produto)
        {
            try
            {
                if (produto == null)
                {
                    return NotFound();
                }

                validacao.Validar(produto);
                _repositorio.AtualizarProduto(produto);
                return Ok(produto);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}