﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<string, string> myMapNode = new MyMapNode<string, string>(5);
            myMapNode.Add("0", "To");
            myMapNode.Add("1", "be");
            myMapNode.Add("2", "or");
            myMapNode.Add("3", "not");
            myMapNode.Add("4", "to");
            myMapNode.Add("5", "be");
            myMapNode.Display();
            Console.ReadLine();
        }
    }
}
