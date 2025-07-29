using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_IceTask1
{
    class Node
    {
        public int value;
        public Node next;
        public Node previous;

        public Node(int value, string? content)
        {
            this.value = value;
        }
    }
}
