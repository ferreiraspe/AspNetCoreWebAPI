using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.V1.Dtos;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.V2.Controllers
{
    /// <summary>
    /// Controller versão 2
    /// </summary>
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IRepository Repo;
        private readonly IMapper Mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="mapper"></param>
        public AlunoController(IRepository repo, IMapper mapper)
        {
            Mapper = mapper;
            Repo = repo;
        }

        /// <summary>
        /// Método responsável por retornar todos os meus alunos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var alunos = Repo.GetAllAlunos(true);

            return Ok(Mapper.Map<IEnumerable<AlunoDto>>(alunos));
        }

        /// <summary>
        /// Método responsável por retornar apenas um Aluno por meio do Código ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Repo.GetAlunoById(id, false);
            if (aluno == null) return BadRequest("O aluno não foi encontrado!");

            var alunoDto = Mapper.Map<AlunoDto>(aluno);

            return Ok(alunoDto);
        }

        /// <summary>
        /// Método responsável por cadastrar novo aluno
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(AlunoRegistrarDto model)
        {
            var aluno = Mapper.Map<Aluno>(model);

            Repo.Add(aluno);
            if (Repo.SaveChange())
            {
                return Created($"/api/aluno/{model.Id}", Mapper.Map<AlunoDto>(aluno));
            }

            return BadRequest("Aluno não cadastrado");
        }

        /// <summary>
        /// Método responsável por atualizar um aluno
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, AlunoRegistrarDto model)
        {
            var aluno = Repo.GetAlunoById(id);
            if (aluno == null) return BadRequest("Aluno não encontrado");

            Mapper.Map(model, aluno);

            Repo.Update(aluno);
            if (Repo.SaveChange())
            {
                return Created($"/api/aluno/{model.Id}", Mapper.Map<AlunoDto>(aluno));
            }

            return BadRequest("Aluno não atualizado!");
        }

        /// <summary>
        /// Método responsável por excluir um aluno
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var aluno = Repo.GetAlunoById(id);
            if (aluno == null) return BadRequest("Aluno não encontrado");

            Repo.Delete(aluno);
            if (Repo.SaveChange())
            {
                return Ok("Aluno deletado!");
            }

            return BadRequest("Aluno não deletado!");
        }
    }
}