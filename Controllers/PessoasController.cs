using CRUDAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPI.Controllers {
    [ApiController]
    [Route ("api/[controller]")]
    public class PessoasController : ControllerBase {
        private readonly Contexto _contexto;

        public PessoasController (Contexto contexto) {
            _contexto = contexto;
        }

       [HttpGet]
        // [Route("/pessoas")]
        public async Task<ActionResult> GetPessoas(){
            return Ok(await _contexto.Pessoas.ToListAsync());
        }
 
        [HttpPost]
        // [Route("/Pessoas")]
        public async Task<ActionResult> CreatePessoa(Pessoa pessoa){
            _contexto.Pessoas.Add(pessoa);
            await _contexto.SaveChangesAsync();
            return Ok(pessoa);
        }

        [HttpPut]
        //[Route("/Pessoas")]
        public async Task<ActionResult> UpdatePessoa(Pessoa Pessoa){
            var dbPessoa = await _contexto.Pessoas.FindAsync(Pessoa.PessoaId);

            if(dbPessoa == null){
                return NotFound();
            }
            dbPessoa.Nome = Pessoa.Nome;
            dbPessoa.Sobrenome = Pessoa.Sobrenome;
            dbPessoa.Profissao = Pessoa.Sobrenome;

            _contexto.SaveChanges();

            return Ok();
        }
            
    
    
          [HttpDelete]
          //  [Route("/pessoa")]
        public async Task<ActionResult> RUpdateProduct(int pessoaId){
            var dbPessoa = await _contexto.Pessoas.FindAsync(pessoaId);

            if(dbPessoa == null){
                return NotFound();
            }
            _contexto.Pessoas.Remove(dbPessoa);
            _contexto.SaveChanges();

            return NoContent();
        }

    }
}
