using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Models.TradingPartner
{
    public class TPCategory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }



        [Column(TypeName = "varchar(100)")]
        public string CategoryName { get; set; }

        public bool IsStatic { get; set; }

        public bool IsActive { get; set; }




    }
}
