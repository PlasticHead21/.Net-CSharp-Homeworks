using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuery
{
    [Serializable]
    public class PRODUCER
    {
        public string ID { get; set; }
        public string NAME { get; set; }
        public DateTime DATE { get; set; }
        public int FEE { get; set; }
    }
}
