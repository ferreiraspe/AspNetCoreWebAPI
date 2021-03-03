using System;

namespace SmartSchool.WebAPI.V1.Dtos
{
    public class AlunoDto
    {
        /// <summary>
        /// Identificador e chave do Banco
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Chave do aluno, para outros negócios na Instituição
        /// </summary>
        public int Matricula { get; set; }
        /// <summary>
        /// Nome é o Primeiro nome e o Sobrenome do Aluno
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Telefone do aluno
        /// </summary>
        public string Telefone { get; set; }
        /// <summary>
        /// Está idade é o calculo relacionado a data de nascimento do aluno
        /// </summary>
        public int Idade { get; set; }
        /// <summary>
        /// Data da matrícula do aluno
        /// </summary>
        public DateTime DataIni { get; set; }
        /// <summary>
        /// Indida se a matrícula está ativa ou não
        /// </summary>
        public bool Ativo { get; set; }
    }
}