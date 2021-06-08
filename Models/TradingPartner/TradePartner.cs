using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Models.TradingPartner
{
    //[Index("Name3", IsUnique = false)]
    //[Index(nameof(Name), IsUnique = false)]
    public class TradePartner
    {



        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }


        
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        //public Guid Id { get; set; }


        /*If primary key is composite */
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key, Column(Order = 0)]
        //public int Id { get; set; }

        //[Key, Column(Order = 1)]
        //public string Name { get; set; }




        [Column(TypeName = "varchar(100)")]
        public string FirstName { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string MiddleName { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string LastName { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string IdNbr { get; set; }




        //[Column("Description2", Order = 2, TypeName = "nvarchar(100)")]
        //public string Name3 { get; set; }



        //[Column("Description")]
        //public string Name4 { get; set; }
        //public string Address { get; set; }
        //public string Mobile { get; set; }

        //public new string StudentNbr { get; set; }

        [Column(TypeName = "varchar(100)")]
        //[Column("Description2", Order = 2, TypeName = "nvarchar(100)")]
        //[MaxLength(100)]
        public virtual string Name3 { get; set; }


        //[Column(nameof(Name), Order = 2, TypeName = "nvarchar(100)")]
        //public string Name3 { get; set; }



        //[Column("Description")]
        //public string Name4 { get; set; }
        //public string Address { get; set; }
        public string Mobile { get; set; }
    }
}
