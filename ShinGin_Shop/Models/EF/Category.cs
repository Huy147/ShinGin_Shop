﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShinGin_Shop.Models.EF
{
    [Table("tb_Category")]
    public class Category : CommonAbstract
    {
        public Category() { 
            this.News = new HashSet<News>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(250)]
        public string Title { get; set; }
        public string Alias { get; set; }
        [StringLength(3000)]
        public string Description { get; set; }
        [StringLength(250)]
        public string SeoTitle { get; set; }
        [StringLength(250)]
        public string SeoDescription { get; set; }
        [StringLength(250)]
        public string SeoKeywords { get; set; }
        [StringLength(250)]
        public string Position { get; set; }

        public ICollection<News> News { get; set; }
        public ICollection <Posts> Posts { get; set; }

    }
}