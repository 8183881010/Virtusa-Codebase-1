using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnMVCUsingEF.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        [Required(ErrorMessage ="Id Required")]
        public int Id { get; set; }
        [StringLength(30)]
        [Column(TypeName ="varchar")]
        [Required(ErrorMessage ="Name Requied")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Year Requied")]
        public int Year { get; set; }
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        [Required(ErrorMessage = "Lang Requied")]
        public string Lang { get; set; }
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        [Required(ErrorMessage = "Actor Requied")]
        public string Actor { get; set; }
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        [Required(ErrorMessage = "Director Requied")]
        public string Director { get; set; }
    }
}