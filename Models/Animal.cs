using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudAsp.Models
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        [Column(TypeName = "varchar(150)")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Nome { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string Especie { get; set; }
        [Column(TypeName = "varchar(150)")]
        [DisplayName("Raça")]
        public string Raca { get; set; }
        [Column(TypeName = "varchar(150)")]
        [DisplayName("Endereço")]
        public string Endereco { get; set; }
    }
}
