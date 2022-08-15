using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class TankOperator : IOperator
    {
        public int TankId { get; set; }

        public void Update(HeadQuarters headQuarters)
        {
            Console.WriteLine("[{0}] : {1}", TankId, headQuarters.Information);
        }
    }
}
