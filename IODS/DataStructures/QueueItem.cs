using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IODS.DataStructures
{
    public class QueueItem
    {
        public int Value { get; set; }
        public QueueItem next = null;

        public QueueItem()
        {

        }

        public QueueItem(int value)
        {
            Value = value;
            next = null;
        }
    }
}
