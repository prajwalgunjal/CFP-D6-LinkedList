using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomeLikedList
{
    public class Node<T>
    {
        public T Data;
        public Node<T> next;

        public Node()
        {

        }
        public Node(T Data)
        {
            this.Data = Data;
        }
    }
}
