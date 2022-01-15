using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiHeros.Model
{
    [Table("herois")]
    public class Heroi
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("nome_heroi")]
        public string NomeHeroi { get; set; }

        [Column("arma_poder")]
        public string ArmaPoder { get; set; }



        


    }
}
