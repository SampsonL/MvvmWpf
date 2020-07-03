using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmWpf.Domain.Entity
{
    public class Material
    {
        public virtual string id { set; get; }
        //    public virtual Position position { set; get; }
        public virtual string positionId { get; set; }
        //       public virtual ICollection<Transfer_Job> transfer_Jobs { set; get; }
    }
}
