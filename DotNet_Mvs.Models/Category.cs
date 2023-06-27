using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Mvc.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Name")]
        [Required]
        [MinLength(1)]
        public string Name { get; set; }
        [Required]
        [Range(1,1000)]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }

    }
}
