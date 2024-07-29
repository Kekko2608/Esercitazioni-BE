﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Progetto_Pizzeria.Models
{
    public class Ordine
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public User User {get; set;}
        [Required]
        public Boolean Evaso { get; set;}
        [Required]
        public string Indirizzo { get; set;}
     
        public string Noteaggiuntive { get; set;}

        [Required]
        public List<ProdottoOrdinato> ProdottiOrdinati { get; set;}
    }
}