using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IODS.DataStructures
{
    public class StackItem
    {
        public int Value { get; set; }
        public StackItem next = null;
    }
}
