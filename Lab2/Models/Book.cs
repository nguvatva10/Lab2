﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Xunit;

namespace Lab2.Models
{
   
     public class Book
    {
        private int id;
        private string title;
        private string author;
        private string image_cover;

        public Book()
        {
        }

        public Book(int id, string title, string author, string image_cover)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.image_cover = image_cover;
        }



        [Required(ErrorMessage = "ID không được trống ")]
        [Display(Name = "Mã sách")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Required(ErrorMessage = "Tiêu đề không được trống ")]
        [StringLength(250, ErrorMessage = "Tiêu đề sách không được vượt quá 250 ký tự")]
        [Display(Name = "Tiêu đề")]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        [Display(Name = "Tác giả")]
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        [Display(Name = "Đường dẫn ảnh bìa")]
        public string Imagecover
        {
            get { return image_cover; }
            set { image_cover = value; }
        }

    }

}