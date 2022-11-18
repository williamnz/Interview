using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tree
{
    public class Node
    {
        public int item;
        public Node left;
        public Node right;
        public Node(int item)
        {
            this.item = item;
        }
    }
}
