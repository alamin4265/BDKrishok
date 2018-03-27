using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Models
{
    [Table("Category")]
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]

        public string Name { get; set; }

        public int? CategoryId { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        public virtual Category SubCategory { get; set; }

    }
}