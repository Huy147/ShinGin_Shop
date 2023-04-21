using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShinGin_Shop.Models
{
    [Table("tb_Subscribe")]
    public class Subscribe : CommonAbstract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(150)]
        public string Email { get; set; }
        public string Webstite { get; set; }
        [StringLength(2000)]
        public string Message { get; set; }
        public bool isRead { get; set; }

    }
}