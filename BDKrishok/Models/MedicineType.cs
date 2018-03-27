using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Models
{
    [Table("MedicineType")]
    public class MedicineType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public virtual ICollection<Medicine> Medicines { get; set; }
        public virtual ICollection<Disease> Diseases { get; set; }

    }
}