using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuikProject.Models
{
    public class ConnectionClass
    {
        public int Id { get; set; }
        public string Server { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Db { get; set; }
    }
}
