using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Models
{
    [Table("Video")]
    public class Video
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(2000)]
        public string Link { get; set; }

        public virtual Feed Feed { get; set; }
        public virtual Medicine Medicine { get; set; }
        public virtual Disease Disease { get; set; }
    }
}