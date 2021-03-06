﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PoPs.Domain;
using System.ComponentModel.DataAnnotations;

namespace PoPs.Web.Models
{
    public class PopViewModel
    {
        [Required(ErrorMessage="Titulo obrigatório")]
        [Display(Name="Título")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Url obrigatória")]
        [Display(Name = "Link")]
        public string Url { get; set; }

        public IList<int> SelectedTags { get; set; }

        public Dictionary<int, string> TagsListItem { get; set; }
    }
}