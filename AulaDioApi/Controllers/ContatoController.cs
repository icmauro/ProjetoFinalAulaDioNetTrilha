using Aula.Data.Infra.Context;
using Aula.Data.Infra.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AulaDioApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        private readonly SistemaContext _context;

        public ContatoController(SistemaContext context)
        {
            _context = context;
        }

        [HttpPost("Criar")]
        public IActionResult Create([FromBody] Contato contato)
        {
            _context.Contatos.Add(contato);
            _context.SaveChanges();

            return Ok(contato);
        }

        [HttpGet("{Id}")]
        public IActionResult ObterPorId(int Id)
        {
            var contatos = _context.Contatos.Find(Id);


            return Ok(contatos);
        }

        [HttpPut("{Id}")]
        public IActionResult Atualizar(int Id, [FromBody] Contato contato)
        {
            var contatosBanco = _context.Contatos.Find(Id);

            if (contatosBanco == null)
            {
                return NotFound();
            }

            contatosBanco.Nome = contato.Nome;
            contatosBanco.Telefone = contato.Telefone;
            contatosBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatosBanco);
            _context.SaveChanges();

            return Ok(contatosBanco);
        }

        [HttpGet("OpterPorNome/{Nome}")]
        public IActionResult ObterPorNome(string nome)
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome)).ToList();

            return Ok(contatos);
        }

        [HttpDelete("{Id}")]
        public IActionResult Deletar(int Id)
        {
            var contatosBanco = _context.Contatos.Find(Id);

            if (contatosBanco == null)
            {
                return NotFound();
            }

            _context.Contatos.Remove(contatosBanco);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
