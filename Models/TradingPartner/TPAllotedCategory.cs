using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Models.TradingPartner
{
    public class TPAllotedCategory
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string CategoryName { get; set; }

        public TradePartner TPFk { get; set; }
        [ForeignKey( nameof(TPFk))]
        
        public virtual int TPId { get; set; }



        public TPCategory TPCatFK { get; set; }
        [ForeignKey(nameof(TPCatFK))]
        
        public virtual int TPCatId { get; set; }



        /*If primary key is composite */
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key, Column(Order = 0)]
        //public int Id { get; set; }

        //[Key, Column(Order = 1)]
        //public string Name { get; set; }


        //[Column(nameof(Name), Order = 2, TypeName = "nvarchar(100)")]
    }
}
