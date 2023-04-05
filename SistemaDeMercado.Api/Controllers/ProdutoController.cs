using Dominio;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_Mercado;
using System.Net;

namespace SistemaDeMercado.Api.Controllers
{
    //comentario teste
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
            catch(Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
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
        public CreatedResult AdicionarProduto(Produto produto)
        {
            try
            {
                if (produto is null)
                {
                    throw new Exception("Produto não informado");
                }

                validacao.Validar(produto);
                _repositorio.AdicionarProduto(produto);
                return Created(produto.Id.ToString(),produto);

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