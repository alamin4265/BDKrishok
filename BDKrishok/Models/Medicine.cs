using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Models
{
    [Table("Medicine")]
    public class Medicine
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Power { get; set; }

        [StringLength(500)]
        public string SideEffect { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public int MedicineTypeId { get; set; }
        public int CompanyId { get; set; }
        public int ShopId { get; set; }
        public int ImageId { get; set; }
        public int VideoId { get; set; }

        public virtual ICollection<MedicineType> MedicineTypes { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Shop> Shops { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Video> Videos { get; set; }

    }
}