using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;

namespace Projeto_BancoDados.Models
{
    public class Usuario
    {
        [Display(Name = "Código")]
        public int idUsu { get; set; }
        
        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "O Campo nome é obrigatório.")]
        public string nomeUsu { get; set; }
        
        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "O Campo cargo é obrigatório.")]
        public string Cargo { get; set; }
        
        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "O Campo data de nascimento é obrigatório.")]
        public DateTime dataNasc { get; set; }
    }
}