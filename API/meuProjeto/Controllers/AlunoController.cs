using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;

namespace API.Controllers{
    [Route("pages/aluno")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly AppDataContext _context;
        public AlunoController(AppDataContext context) =>
        _context = context;

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar(){
            List<Aluno> alunos = _context.Alunos.ToList();
            return Ok(alunos);
        }
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody]Aluno aluno){

            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            return Created("",aluno);
        }

    }
}
