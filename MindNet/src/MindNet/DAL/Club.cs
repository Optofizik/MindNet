using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MindNet.DAL
{
    public class Club
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int FundationYear { get; set; }
        public string Country { get; set; } 
    }
}
