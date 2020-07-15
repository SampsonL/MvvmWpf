using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmWpf.Domain.Entity
{
    public class Transfer_Job
    {
        public virtual string id { set; get; }
        public virtual string src_position_id { set; get; }
        public virtual string dest_position_id { set; get; }
        public virtual string transfer_job_type{set;get;}
        public virtual string transfer_job_actor { set; get; }
        public virtual string containerId { set; get; }

   //     public virtual Material material { set; get; }
    }
}
