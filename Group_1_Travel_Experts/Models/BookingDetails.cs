﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Group_1_Travel_Experts.Models
{
    public partial class BookingDetails
    {
        [Key]
        public int BookingDetailId { get; set; }
        public double? ItineraryNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TripStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TripEnd { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string Destination { get; set; }
        [Column(TypeName = "money")]
        public decimal? BasePrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? AgencyCommission { get; set; }
        public int? BookingId { get; set; }
        [StringLength(5)]
        public string RegionId { get; set; }
        [StringLength(5)]
        public string ClassId { get; set; }
        [StringLength(10)]
        public string FeeId { get; set; }
        public int? ProductSupplierId { get; set; }

        [ForeignKey(nameof(BookingId))]
        [InverseProperty(nameof(Bookings.BookingDetails))]
        public virtual Bookings Booking { get; set; }
        [ForeignKey(nameof(ClassId))]
        [InverseProperty(nameof(Classes.BookingDetails))]
        public virtual Classes Class { get; set; }
        [ForeignKey(nameof(FeeId))]
        [InverseProperty(nameof(Fees.BookingDetails))]
        public virtual Fees Fee { get; set; }
        [ForeignKey(nameof(ProductSupplierId))]
        [InverseProperty(nameof(ProductsSuppliers.BookingDetails))]
        public virtual ProductsSuppliers ProductSupplier { get; set; }
        [ForeignKey(nameof(RegionId))]
        [InverseProperty(nameof(Regions.BookingDetails))]
        public virtual Regions Region { get; set; }
    }
}
