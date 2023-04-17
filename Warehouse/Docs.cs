using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Docs
    {
        public Docs(int Id, string Name, int Date)
        {
            this.Id = Id;
            this.Name = Name;
            this.Date = Date;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Date { get; set; }
    }
}
