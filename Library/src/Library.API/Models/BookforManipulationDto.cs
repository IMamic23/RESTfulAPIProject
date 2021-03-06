﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Models
{
    public abstract class BookForManipulationDto 
    {
        [MaxLength(100, ErrorMessage = "The title shouldn't have more than 100 characters.")]
        [Required(ErrorMessage = "You should fill out a title")]
        public string Title { get; set; }
        [MaxLength(500, ErrorMessage = "The description shouldn't have more than 500 characters.")]
        public virtual string Description { get; set; }
    }
}
