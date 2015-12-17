﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZQNet.Presentation.Web.ZQPhoenix.Models
{
    public class Author
    {
        [ScaffoldColumn(false)]
        public int AuthorID { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}