using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TPFinalLabo4.Models
{
    public class Product
    {
        public Product()
        {
            this.SupplierProduct = new HashSet<SupplierProduct>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto no puede estar vacío.")]
        [StringLength(50, ErrorMessage = "El {0} debe contener entre {2} y {1} caracteres", MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z0-9'-'\s]*$", ErrorMessage = "El nombre del producto debe contener solo letras, números y espacios.")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El precio del producto no puede estar vacío.")]
        [Range(0.10, 10000000, ErrorMessage = "Por favor, ingrese un precio entre 0,10 and 10.000.000,00 de pesos.")]
        [Column(TypeName = "decimal(18,2)")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [RegularExpression("[0-9]+(\\.[0-9][0-9]?)?", ErrorMessage = "El precio debe ser un número con hasta dos decimales.")]
        [Display(Name = "Precio")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "La descripción del producto es obligatoria")]
        [StringLength(500, ErrorMessage = "El {0} debe contener entre {2} y {1} caracteres", MinimumLength = 30)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Descripción")]
        public string Description { get; set; }

        [Display(Name = "Favorito")]
        public bool Favourite { get; set; }

        [ForeignKey("Category")]
        [Display(Name = "Id-Categoria")]
        public int CategoryId { get; set; }

        [Display(Name = "Categoria")]
        public virtual Category Category { get; set; }

        [ForeignKey("Brand")]
        [Display(Name = "Id-Marca")]
        public int BrandId { get; set; }

        [Display(Name = "Marca")]
        public virtual Brand Brand { get; set; }

        [Display(Name = "Proveedores")]
        public ICollection<SupplierProduct> SupplierProduct { get; set; }

        [Display(Name = "Foto")]
        public string Photo { get; set; }
    }
}
