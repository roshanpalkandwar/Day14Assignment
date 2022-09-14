using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkLIASt2
{
    internal class CustmerLinkLIST
    {
        Nodes head;
        public void AddEnd(int dataNew)
        {
            Nodes NewData=new Nodes(dataNew);

            if(this.head == null)
            {
                this.head=NewData; 
            }
            else
            {
                Nodes temp=head;
                while (temp.next != null)
                {
                    temp=temp.next;

                }
                temp.next=NewData;
              
            }
        }
        public void Display()
        {
            Nodes temp=this. head;
            if(temp==null)
            {
                Console.WriteLine("link list is empty");
            }
            while(temp!=null)
            {
                Console.WriteLine(temp.data);
                temp=temp.next;
            }
        }
       
    }
}
