using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace APISemana9.Model
{
    [Table("Semana")]
    public class SemanaModel
    {
        [Key]
        [Column("CODIGO")]
        public int ID { get; set; }

        [MaxLength(100)]
        public DateTime DataSemana { get; set; }
        public bool AplicadoConteudo { get; set; } 

    }
}