using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace linkLIASt2
{
    internal class CustmerLinkLIST
    {
        internal Nodes head;

        internal void Add(int data)
        {
            Nodes node = new Nodes(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Nodes temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        internal void Display()
        {
            Nodes temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }


        public bool InsertAfter(int data, int after)    //insert in between the sequences
        {
            bool flag = false;
            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Nodes temp = head;
                while (temp != null)
                {
                    if (temp.data == after)
                    {
                        Nodes newNode = new Nodes(data);
                        newNode.next = temp.next;
                        temp.next = newNode;
                        flag = true;
                        break;
                    }
                    temp = temp.next;
                }
                if (!flag)
                    Console.WriteLine("The Element is Absent");
            }
            return flag;
        }

        internal int Search(int value)
        {
            Nodes node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        internal Nodes InsertNthPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid Position");
            if (position == 1)
            {
                var newNode = new Nodes(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Nodes newNode = new Nodes(data);
                        newNode.next = this.head.next;
                        head.next = newNode;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }

        internal Nodes RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }

        internal Nodes RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Nodes newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
        public bool DeleteAnyElement(int data)     //delete data
        {
            bool flag = false;
            int count = 0;

            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Nodes temp = head;
                Nodes previousNode = null;
                while (temp != null)
                {
                    count++;
                    if (temp.data == data)
                    {
                        if (count == 1)
                        {
                            head = temp.next;
                        }
                        else
                        {
                            previousNode.next = temp.next;
                        }
                        flag = true;
                        break;
                    }
                    previousNode = temp;
                    temp = temp.next;
                }
                if (!flag)
                    Console.WriteLine("The Element is not in List");
            }

            return flag;
        }
        public int size()
        {
            Nodes temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
    }        
      
              
                   
           
}
