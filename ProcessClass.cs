using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace process_simulation
{
    public class ProcessClass
    {
        public int id, n1, n2, result, time;
        public string name, op;

        public ProcessClass(int id,int n1, int n2, int result,int time, string name, string op)
        {
            this.id = id;
            this.n1 = n1;
            this.n2 = n2;
            this.result = result;
            this.time = time;
            this.name = name;
            this.op = op;
        }
    }
}
