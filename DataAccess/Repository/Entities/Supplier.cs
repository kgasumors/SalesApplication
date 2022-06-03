using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository.Entities
{
    public partial class Supplier
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("code")]
        public int? Code { get; set; }
        [Column("supplierName")]
        [StringLength(500)]
        [Unicode(false)]
        public string? SupplierName { get; set; }
        [Column("telephoneNumber")]
        [StringLength(50)]
        [Unicode(false)]
        public string? TelephoneNumber { get; set; }
    }
}
