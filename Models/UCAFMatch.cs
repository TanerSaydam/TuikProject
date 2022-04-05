using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuikProject.Models
{
    public class UCAFMatch
    {
        public int Id { get; set; }
        public int UCAFId { get; set; }
        public string Match { get; set; }
        public decimal Total { get; set; }
    }
}
