using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Manout.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name ="Descrição")]
        [Required(ErrorMessage ="Obrigatório")]
        public string Descricao { get; set; }
        [Range(1,999,ErrorMessage ="Value out of Range!")]
        public int Quantidade { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
