using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    public class StackUsingLL
    {
        public Node head;
        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }

        public void push(int data)
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

        public void pop()
        {
            if (head == null)
            {
                Console.WriteLine("Stack Is Empty");
                return;
            }
            head = head.next;

        }

        public void peek()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.Write(head.data);

        }

        public void display()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }





        static void Main(string[] args)
        {
            StackUsingLL stack = new StackUsingLL();
            //stack.push(1);
            //stack.push(2);
            //stack.push(3);
            //stack.push(4);
            //stack.push(5);
            //stack.push(6);
            //stack.peek();

            int choice;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nStack ");
                Console.WriteLine("1. Push In Stack");
                Console.WriteLine("2. Pop From Stack");
                Console.WriteLine("3. Peek In Stack");
                Console.WriteLine("4. Display All Elements");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Your Choice : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the number to push in Stack :");
                        int num = int.Parse(Console.ReadLine());
                        stack.push(num);
                        break;

                    case 2:
                        stack.pop();
                        break;

                    case 3:
                        stack.peek();
                        break;

                    case 4:
                        stack.display();
                        break;

                    case 5:
                        exit = true;
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.Write("Invalid Choice :");
                        break;


                }
            }

        }
    }
}
