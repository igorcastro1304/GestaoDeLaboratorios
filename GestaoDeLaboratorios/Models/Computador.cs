using System.ComponentModel.DataAnnotations;

namespace GestaoDeLaboratorios.Models
{
    public class Computador
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Processador { get; set; }
        [Required]
        [Display(Name = "Placa Mãe")]
        public string PlacaMae { get; set; }
        [Required]
        [Display(Name = "Memória")]
        public string Memoria { get; set; }
        [Required]
        [Display(Name = "HD")]
        public string Hd { get; set; }
        [Required]
        [Display(Name = "Número Patrimonial")]
        public string NumeroPatrimonio { get; set; }
        [Required]
        [Display(Name = "Data da Compra")]
        public string DataCompra { get; set; }
    }
}
