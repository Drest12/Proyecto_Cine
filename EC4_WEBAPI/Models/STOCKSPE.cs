using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EC4_WEBAPI.Models
{
    public class STOCKSPE
    {
        [Key]

        public int id_producto { get; set; }
        public string nom_producto { get; set; }
        public string des_producto { get; set; }
        public double pre_producto { get; set; }
        public int sto_producto { get; set; }

    }
}
