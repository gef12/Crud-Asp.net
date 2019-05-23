using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Asp.net.Models
{
    public class Empregado
    {
        //representação da tabela funcionario/empregado
        //anotacao para os atributo
        [Key]
        public int EmpregadoId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]

        public string NameCompleto { get; set; }
        [Column(TypeName = "varchar(20)")]

        public string EmpCode { get; set; }
        [Column(TypeName = "varchar(100)")]

        public string Posicao { get; set; }
        [Column(TypeName = "varchar(100)")]

        public string LocalizacaoTrabalho { get; set; }
    }
}
