﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Opdracht2.Models.Entities
{
    public partial class Brewery
    {
        public Brewery()
        {
            Beers = new HashSet<Beer>();
        }

        [Key]
        public int Brouwernr { get; set; }
        public string Naam { get; set; } = null!;
        public string Adres { get; set; } = null!;
        public string Postcode { get; set; } = null!;
        public string Gemeente { get; set; } = null!;
        public decimal? Omzet { get; set; }

        public virtual ICollection<Beer> Beers { get; set; }
    }
}
