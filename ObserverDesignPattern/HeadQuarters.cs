using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class HeadQuarters
    {
        private string _information;
        private List<IOperator> _operators = null;

        public HeadQuarters(string information)
        {
            _operators = new List<IOperator>();
            _information = information;
        }
        public string Information
        {
            get { return _information; }
            set { _information = value; NotifyOperators(); }
        }

        public void AddOperator(IOperator opt)
        {
            _operators.Add(opt);
        }
        public void RemoveOperator(IOperator opt)
        {
            _operators.Remove(opt);
        }
        public void NotifyOperators()
        {
            foreach (IOperator opt in _operators)
            {
                opt.Update(this);
            }
        }


    }
}
