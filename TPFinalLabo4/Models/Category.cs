using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TPFinalLabo4.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La descripción de la categoría es obligatoria")]
        [StringLength(30, ErrorMessage = "La {0} debe contener entre {2} y {1} caracteres", MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z0-9'-'\s]*$", ErrorMessage = "El nombre del proveedor debe contener solo letras, números y espacios.")]
        [Display(Name = "Descripción")]
        public string Description { get; set; }
    }
}
