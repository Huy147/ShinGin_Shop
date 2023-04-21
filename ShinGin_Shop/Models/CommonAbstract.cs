using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShinGin_Shop.Models
{
    public abstract class CommonAbstract
    {
        // Được tạo bởi
        public string CreatedBy { get; set; }
        // Được sửa đổi bởi
        public string Modifiedby { get; set; }
        // Ngày tạo
        public DateTime CreatedDate { get; set; }
        // Ngày sửa
        public DateTime ModifiedbyDate { get; set;}

    }
}