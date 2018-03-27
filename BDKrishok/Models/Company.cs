using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Models
{
    [Table("Company")]
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Contact { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public int CityId { get; set; }
        public int ImageId { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Feed> Feeds { get; set; }
        public virtual ICollection<Medicine> Medicines { get; set; }

    }
}