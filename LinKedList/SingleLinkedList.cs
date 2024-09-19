using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinKedList
{
    public class SingleLinkedList
    {
        public Node head;


        // Creation of node which contain data and address of next node
        public class Node
        {
            public Node next;
            public int data;

            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }

           public Node(int data, Node next)
            {
                this.data = data;
                this.next = next;
                
            }

        }

        // Method To Add Node At first Position
        public void addFirst(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            newNode.next = head;
            head = newNode;
        }


        // Method To Print List
        public void printList()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Node currNode = head;
            while (currNode != null)
            {
                Console.Write(currNode.data + "->");
                currNode = currNode.next;
            }
            Console.Write("Null");

        }


        // Method To Add Node At Last Position
        public void addlast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node currNode = head;
            while (currNode.next != null)
            {
                currNode = currNode.next;
            }

            currNode.next = newNode;
        }

        // Method to add data at an particular index
        public void insert(int data, int index)
        {
            if (index == 0)
            {
                addFirst(data);
                return;
            }
            
            Node temp = head;
            for (int i = 1; i < index; i++)
            {
                temp = temp.next;
            }
            Node node = new Node(data, temp.next);
            temp.next = node;
         
        }

        // Method to delete First Node 
        public void deleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            head = head.next;
        }

        // Method to delete last Node 
        public void deleteLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            if (head.next == null)
            {
                head = null;
                return;
            }
            Node secondLast = head;
            Node lastNode = head.next;
            while (lastNode.next != null)
            {
                lastNode = lastNode.next;
                secondLast = secondLast.next;
            }
            secondLast.next = null;
        }

        static void Main(string[] args)
        {
            SingleLinkedList list = new SingleLinkedList();
            int choice;
            bool exit = false;
            //list.addlast(0);
            //list.addlast(1);
            //list.addlast(2);
            //list.addlast(3);
            //list.insert(5, 2);
            //list.printList();
            //list.deleteLast();
            //Console.WriteLine();
            //list.printList();
            //Console.WriteLine();
            //list.deleteFirst();
            //Console.WriteLine();
            //list.printList();

            while (!exit)
            {
                Console.WriteLine("\nLinked List");
                Console.WriteLine("1. Add First");
                Console.WriteLine("2. Add Last");
                Console.WriteLine("3. Add Value At Particular Index");
                Console.WriteLine("4. Delete Fisrt Node");
                Console.WriteLine("5. Delete Last Node");
                Console.WriteLine("6. Display");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the value to add at the beginning: ");
                        int valFirst = int.Parse(Console.ReadLine());
                        list.addFirst(valFirst);
                        break;

                    case 2:
                        Console.Write("Enter the value to add at the end: ");
                        int valLast = int.Parse(Console.ReadLine());
                        list.addlast(valLast);
                        break;

                    case 3:
                        Console.Write("Enter the value to add at the Particular Index: ");
                        int val = int.Parse(Console.ReadLine());
                        Console.Write("Enter the Index: ");
                        int index = int.Parse(Console.ReadLine());
                        list.insert(val, index);

                        break;

                    case 4:
                        list.deleteFirst();
                        break;

                    case 5:
                        list.deleteLast();
                        break;

                    case 6:
                        list.printList();
                        break;

                    case 7:
                        exit = true;
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }


            }
        }
    }
}

