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
            tree.insert(22);
            tree.insert(40);
            tree.insert(60);
            tree.insert(95);
            tree.insert(11);
            tree.insert(3);
            tree.insert(16);
            tree.insert(65);
            tree.insert(63);
            tree.insert(67);


            // Print inorder traversal of the BST
            tree.inorder();
            var num = tree.search(tree.root,63);
            Console.WriteLine("node is " + num);

        }
    }

}