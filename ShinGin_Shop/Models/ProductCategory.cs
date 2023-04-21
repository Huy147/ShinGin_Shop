using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShinGin_Shop.Models
{
    [Table("tb_ProductCategory")]
    public class ProductCategory
    {
        public int Id { get; set; }

    }
}