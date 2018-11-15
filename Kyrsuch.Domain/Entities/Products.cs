using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Kyrsuch.Domain.Entities
{
    public class Products
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter a name for the game")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please enter a description for the game")]
        public string Description { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Please specify a category for the game")]
        public string Category { get; set; }

        [Display(Name = "Price (grn)")]
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive value for the price")]
        public decimal Price { get; set; }
    }
}
