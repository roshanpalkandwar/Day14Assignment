using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkLIASt2
{
    internal class Nodes
    {
        public int data;
        public Nodes next;
        Nodes T;
        public Nodes(int data)
        {
            this.data =data;
            next =null;
        }
    }
}
