using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.V1.Dtos;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.V1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ProfessorController : ControllerBase
    {

        private readonly IRepository Repo;
        private readonly IMapper Mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="mapper"></param>
        public ProfessorController(IRepository repo, IMapper mapper)
        {
            Mapper = mapper;
            Repo = repo;
        }

        /// <summary>
        /// Método responsável por retornar todos os meus professores
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var professor = Repo.GetAllProfessores(true);

            return Ok(Mapper.Map<IEnumerable<ProfessorDto>>(professor));
        }

        /// <summary>
        /// Método responsável por retornar um único ProfessorDTO.
        /// </summary>
        /// <returns></returns>
        [HttpGet("getRegister")]
        public IActionResult GetRegister()
        {
            return Ok(new ProfessorRegistrarDto());
        }

        /// <summary>
        /// Método responsável por retornar apenas um Professor por meio do Código ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{Id}")]
        public IActionResult GetById(int id)
        {
            var professor = Repo.GetProfessorById(id, true);
            if (professor == null) return BadRequest("O professor não foi encontrado!");

            var professorDto = Mapper.Map<ProfessorDto>(professor);

            return Ok(professor);
        }

        [HttpGet("byaluno/{alunoId}")]
        public IActionResult GetByAlunoId(int alunoId)
        {
            var professores = Repo.GetProfessoresByAlunoId(alunoId, true);
            if (professores == null) return BadRequest("Professores não encontrados!");

            return Ok(Mapper.Map<IEnumerable<ProfessorDto>>(professores));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(ProfessorRegistrarDto model)
        {
            var prof = Mapper.Map<Professor>(model);

            Repo.Add(prof);
            if (Repo.SaveChange())
            {
                return Created($"/api/professor/{model.Id}", Mapper.Map<ProfessorDto>(prof));
            }

            return BadRequest("Professor não encontrado!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, ProfessorRegistrarDto model)
        {
            var prof = Repo.GetProfessorById(id);
            if (prof == null) return BadRequest("Professor não encontrado!");

            Mapper.Map(model, prof);

            Repo.Update(prof);
            if (Repo.SaveChange())
            {
                return Created($"/api/professor/{model.Id}", Mapper.Map<ProfessorDto>(prof));
            }

            return BadRequest("Professor não atualizado!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, ProfessorRegistrarDto model)
        {
            var prof = Repo.GetProfessorById(id);
            if (prof == null) return BadRequest("Professor não encontrado!");

            Mapper.Map(model, prof);

            Repo.Update(prof);
            if (Repo.SaveChange())
            {
                return Created($"/api/professor/{model.Id}", Mapper.Map<ProfessorDto>(prof));
            }

            return BadRequest("Professor não atualizado!");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var professor = Repo.GetProfessorById(id);
            if (professor == null) return BadRequest("Professor não encontrado!");

            Repo.Delete(professor);
            if (Repo.SaveChange())
            {
                return Ok("Professor deletado!");
            }

            return BadRequest("Professor não deletado!");
        }

    }
}