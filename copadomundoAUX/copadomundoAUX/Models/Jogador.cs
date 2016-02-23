﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CopaDoMundo.Models
{
    [Table("Jogadores")]
    public class Jogador
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Posicao é obrigatório.")]
        public string Posicao { get; set;}
        [Required(ErrorMessage = "O campo Nascimento é obrigatório.")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }
        [Required(ErrorMessage = "O campo Altura é obrigatório.")]
        public double Altura { get; set; }
        public int SelecaoId { get; set; }
        [InverseProperty("Jogadores")]
        public Selecao Selecao { get; set; }
    }
}