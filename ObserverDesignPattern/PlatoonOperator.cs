using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class PlatoonOperator : IOperator
    {
        public string OperatorName { get; set; }
        public void Update(HeadQuarters headQuarters)
        {
            Console.WriteLine("[{0}] : {1}", OperatorName, headQuarters.Information);
        }
    }
}
