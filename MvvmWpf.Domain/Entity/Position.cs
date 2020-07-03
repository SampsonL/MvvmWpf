using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmWpf.Domain.Entity
{
    public class Position
    {
        public virtual string id { set; get; }
        public virtual string state { set; get; }
        public virtual string rackId { set; get; }
        
    }
}
