using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Mvc.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Name")]
        [Required]
        [MinLength(1)]
        public string Name { get; set; }
        [Required]
        [MinLength(10)]
        [DisplayName("Description")]
        public string Description { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        [DisplayName("Price")]
        public int Price { get; set; }
     
        [ValidateNever]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        [DisplayName("Category Type")]
        public Category Category {get; set;}

        
        [DisplayName("Upload Image")]
        [ValidateNever]
        public string ImageURl { get; set;}

    }
}
