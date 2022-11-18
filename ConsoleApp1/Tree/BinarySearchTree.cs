using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tree
{
    public class BinarySearchTree
    {
        public Node root;
        public Node GetRoot()
        {
            return root;
        }
        public BinarySearchTree()
        {
            root = null;
        }

        public void Preorder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.item + " ");
                Preorder(Root.left);
                Preorder(Root.right);
            }
        }
        public void Inorder(Node Root)
        {
            if (Root != null)
            {
                Inorder(Root.left);
                Console.Write(Root.item + " ");
                Inorder(Root.right);
            }
        }
        public void Postorder(Node Root)
        {
            if (Root != null)
            {
                Postorder(Root.left);
                Postorder(Root.right);
                Console.Write(Root.item + " ");
            }
        }

        public int GetHeight(Node root)
        {
            // Write your code here
            if (root == null)
                return -1;
            else
            {
                /* compute the depth of each subtree */
                int lDepth = GetHeight(root.left);
                int rDepth = GetHeight(root.right);

                /* use the larger one */
                if (lDepth > rDepth)
                    return (lDepth + 1);
                else
                    return (rDepth + 1);
            }
        }

        public void InsertNodeItem(int val)
        {
            Node current;
            if (root == null)
                root = new Node(val);
            else
            {
                current = root;

                while (true)
                {
                    if (val < current.item)
                    {
                        if (current.left != null)
                        {
                            current = current.left;
                        }
                        else
                        {
                            current.left = new Node(val);
                            break;
                        }
                    }
                    else
                    {
                        if (val > current.item)
                        {
                            if (current.right != null)
                            {
                                current = current.right;
                            }
                            else
                            {
                                current.right = new Node(val);
                                break;
                            }
                        }
                        else
                            break;
                    }
                }
            }
        }
    }
}
