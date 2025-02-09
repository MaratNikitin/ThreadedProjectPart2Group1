﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Group_1_Travel_Experts.Models
{
    public partial class Agencies
    {
        public Agencies()
        {
            Agents = new HashSet<Agents>();
        }

        [Key]
        public int AgencyId { get; set; }
        [StringLength(50)]
        public string AgncyAddress { get; set; }
        [StringLength(50)]
        public string AgncyCity { get; set; }
        [StringLength(50)]
        public string AgncyProv { get; set; }
        [StringLength(50)]
        public string AgncyPostal { get; set; }
        [StringLength(50)]
        public string AgncyCountry { get; set; }
        [StringLength(50)]
        public string AgncyPhone { get; set; }
        [StringLength(50)]
        public string AgncyFax { get; set; }

        [InverseProperty("Agency")]
        public virtual ICollection<Agents> Agents { get; set; }
    }
}
