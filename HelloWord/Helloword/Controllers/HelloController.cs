using Microsoft.AspNetCore.Mvc;

namespace Helloword.Controllers
{
    [Route("~/")]
    [ApiController]
    public class HelloController
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello Turma .NET 03!";
        }

        [HttpGet("/bsm")]
        public string Bsm()
        {
            return "Responsabilidade Pessoal \n Mentalidade de crescimento \n Orientação ao futuro \n Persistência \n Comunicação \n Orientação aos Detalhes \n Trabalho em equipe \n Proatividade";
        }

        [HttpGet("/objetivos")]
        public string Objetivos()
        {
            return "ASP.NET \nSQL";
        }
    }
}
