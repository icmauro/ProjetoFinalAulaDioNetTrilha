using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AulaDioApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToShortDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }

        [HttpGet("Apresentacao/{nome}")]
        public IActionResult Apresentacao(string nome)
        {
            var mensagem = $"Ólá {nome} seja bem vindo!";

            return Ok(mensagem);
        }
    }
}
