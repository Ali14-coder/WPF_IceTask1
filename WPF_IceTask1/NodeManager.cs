using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_IceTask1
{
    public class NodeManager
    {
        public Node Head;

        public void Add(int number, string contents) //this adds the 'chapter number' into the node
        {
            if (number == null && contents == null)
            {
                return;
            }
            else if (Head == null)
            {
                Head = new Node(number,contents);
                return;
            }
            else
            {
                Node n = new Node(number,contents);
                Node current = Head;
                while (current.next != null)
                {
                    current = current.next;
                }
                n.previous = current;
                current.next = n;
            }
        }
    }
}
//dma overfull
//check if it's working on his side - scanning image 
//write out what you're doing and start figuring it out