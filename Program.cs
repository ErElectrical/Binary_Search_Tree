using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BSTDemo
{
    public class Program
    {
        static void Main(String[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.insert(56);
            tree.insert(30);
            tree.insert(70);
        

            // Print inorder traversal of the BST
            tree.inorder();
        }
    }

}
