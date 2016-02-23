using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Validacao.Models
{
    public class Jogador
    {
        [HiddenInput(DisplayValue = false)]
        public int JogadorId { get; set; }
        [Required(ErrorMessage = "O nome do jogador é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O número do jogador é obrigatório")]
        [Range(1, 99,  ErrorMessage = "O número do jogador deve ser maior que 0 e menor que 100")]
        public int ? Numero { get; set; }
        [Required(ErrorMessage = "A altura do jogador é obrigatória")]
        [Range(0, double.MaxValue, ErrorMessage = "A altura do jogador não pode ser negativa")]
        public double ? Altura { get; set; }
    }
}