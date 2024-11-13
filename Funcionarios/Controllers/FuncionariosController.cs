using Microsoft.AspNetCore.Mvc;
using Funcionarios.Models;

namespace EmployeeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionariosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Funcionario>> GetFuncionarios()
        {
            var funcionarios = new List<Funcionario>
            {
                new Funcionario(Guid.NewGuid(), "Leonardo", "Silva", "Desenvolvedor", 500.50M),
                new Funcionario(Guid.NewGuid(), "Fabio", "Faria", "Gestor de Projetos", 450.75M),
                new Funcionario(Guid.NewGuid(), "Victor", "Franca", "Desenvolvedor", 700.00M),
                new Funcionario(Guid.NewGuid(), "Gabriel", "Lourenço", "Automação", 600.25M),
                new Funcionario(Guid.NewGuid(), "Yohanna", "Vavra", "Analista de Qualidade", 600.25M),
                new Funcionario(Guid.NewGuid(), "Alexandre", "Roldao", "Desenvolvedor", 600.25M)
            };

            return Ok(funcionarios);
        }
    }
}
