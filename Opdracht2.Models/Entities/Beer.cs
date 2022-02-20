using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Opdracht2.Models.Entities
{
    public partial class Beer
    {
        public int Biernr { get; set; }
        public string Naam { get; set; } = null!;
        public int Brouwernr { get; set; }
        public int Soortnr { get; set; }
        public decimal? Alcohol { get; set; }
        public string? Image { get; set; }

        [Display(Name = "Brouwerij")]
        public virtual Brewery BrouwernrNavigation { get; set; } = null!;
        [Display(Name = "Biersoort")]
        public virtual Variety SoortnrNavigation { get; set; } = null!;
    }
}
