//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Stack_Queue
//{
//    public class QueueUsingLL
//    {
//        public Node head;
//        public class Node
//        {
//            public int data;
//            public Node next;

//            public Node(int data)
//            {
//                this.data = data;
//                this.next = null;

//            }

//        }

//        public void enqueue(int data)
//        {
//            Node newNode = new Node(data);
//            if (head == null)
//            {
//                head = newNode;
//                return;
//            }
//            newNode.next = head;
//            head = newNode;
//        }

//        public void dequeue()
//        {
//            if (head == null)
//            {
//                Console.WriteLine("Queue Is Empty");
//                return;
//            }
//            if (head.next == null)
//            {
//                head = null;
//                return;
//            }
//            Node secondLast = head;
//            Node last = head.next;
//            while (last.next != null)
//            {
//                last = last.next;
//                secondLast = secondLast.next;
//            }
//            secondLast.next = null;

//        }

//        public void peek()
//        {
//            if (head == null)
//            {
//                Console.WriteLine("Queue is Empty");
//                return;
//            }

//            Node temp = head;
//            while (temp.next != null)
//            {
//                temp = temp.next;
//            }
//            Console.WriteLine(temp.data);
//        }

//        public void display()
//        {
//            if (head == null)
//            {
//                Console.WriteLine("Queue is Empty");
//                return;
//            }
//            Node temp = head;
//            while (temp != null)
//            {
//                Console.WriteLine(temp.data + " ");
//                temp = temp.next;
//            }
//        }




//        static void Main(string[] args)
//        {
//            QueueUsingLL queue = new QueueUsingLL();

//            //queue.enqueue(1);
//            //queue.enqueue(2);
//            //queue.enqueue(3);
//            //queue.enqueue(4);
//            //queue.enqueue(5);
//            //queue.enqueue(6);
//            //queue.enqueue(7);

//            //queue.display();
//            //queue.peek();
//            //queue.dequeue();
//            //queue.display();


//            int choice;
//            bool exit = false;

//            while (!exit)
//            {
//                Console.WriteLine("\nQueue ");
//                Console.WriteLine("1. Enqueue In Queue");
//                Console.WriteLine("2. Dequeue From Queue");
//                Console.WriteLine("3. Peek In Queue");
//                Console.WriteLine("4. Display All Elements");
//                Console.WriteLine("5. Exit");
//                Console.Write("Enter Your Choice : ");
//                choice = int.Parse(Console.ReadLine());

//                switch (choice)
//                {
//                    case 1:
//                        Console.Write("Enter the number to push in Queue :");
//                        int num = int.Parse(Console.ReadLine());
//                        queue.enqueue(num);
//                        break;

//                    case 2:
//                        queue.dequeue();
//                        break;

//                    case 3:
//                        queue.peek();
//                        break;

//                    case 4:
//                        queue.display();
//                        break;

//                    case 5:
//                        exit = true;
//                        Console.WriteLine("Exit");
//                        break;

//                    default:
//                        Console.Write("Invalid Choice :");
//                        break;


//                }
//            }


//        }
//    }
//}
