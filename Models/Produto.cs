using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MacLancheFelizFabricio.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        [DisplayName("Nome do Produto")]
        public string Nome { get; set; }

        
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [Range(0.01, 9999.99, ErrorMessage = "Informe um valor válido para o preço")]
        public decimal Preco { get; set; }

       
    }
}
