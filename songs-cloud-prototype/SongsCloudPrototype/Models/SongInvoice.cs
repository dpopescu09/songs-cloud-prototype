using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SongsCloudPrototype.Models
{
    [Table("SongInvoice")]
    public class SongInvoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SongInvoiceId { get; set; }
        public int SongId { get; set; }
        public double Price { get; set; }

    }
}
