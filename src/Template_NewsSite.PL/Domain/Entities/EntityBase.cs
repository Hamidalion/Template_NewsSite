﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Template_NewsSite.PL.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase()
        {
            DateAdded = DateTime.UtcNow;
        }

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "News title")]
        public virtual string Title { get; set; }

        [Display(Name = "Short description")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Full description")]
        public virtual string Text { get; set; }

        [Display(Name = "Title picture")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "SEA metatag Title")]
        public string MetaTitle { get; set; }

        [Display(Name = "SEA metatag Description")]
        public string MetaDescription { get; set; }

        [Display(Name = "SEA metatag Keywords")]
        public string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
