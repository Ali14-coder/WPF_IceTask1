using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_IceTask1
{
    public class Node //made this class public so that it is accessible to the main window
    {
        public int value;
        public string contents;
        public Node next;
        public Node previous;

        public Node(int value, string contents)
        {
            this.value = value;
            this.contents = contents;
        }
    }
}
