using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmWpf.Domain.Entity
{
    public class Container
    {
        public virtual string id { get; set; }
        public virtual string position_id { get; set; }
        public virtual string name { get; set; }
    }
}
