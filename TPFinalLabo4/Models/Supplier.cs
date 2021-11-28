using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TPFinalLabo4.Models
{
    public class Supplier
    {
        public Supplier()
        {
            this.SupplierProduct = new HashSet<SupplierProduct>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del proveedor no puede estar vacío.")]
        [StringLength(50, ErrorMessage = "El {0} debe contener entre {2} y {1} caracteres", MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z0-9'-'\s]*$", ErrorMessage = "El nombre del proveedor debe contener solo letras, números y espacios.")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El número de teléfono no puede estar vacío.")]
        [StringLength(20, ErrorMessage = "El {0} debe contener entre {2} y {1} caracteres", MinimumLength = 3)]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Por favor, ingrese un número de teléfono váildo")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Teléfono")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "El domicilio es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe contener entre {2} y {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Domicilio")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "La localidad es obligatoria")]
        [StringLength(50, ErrorMessage = "La {0} debe contener entre {2} y {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Localidad")]
        public string City { get; set; }

        [Required(ErrorMessage = "La provincia es obligatoria")]
        [StringLength(50, ErrorMessage = "La {0} debe contener entre {2} y {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Provincia")]
        public string State { get; set; }

        [Display(Name = "Productos")]
        public ICollection<SupplierProduct> SupplierProduct { get; set; }
    }
}
