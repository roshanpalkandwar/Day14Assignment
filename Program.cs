namespace linkLIASt2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("chooes Number\n1.simple Linked List");
            int opt=Convert.ToInt32(Console.ReadLine());
            switch(opt)
            {
                case 1:
                    CustmerLinkLIST custmerLinkLIST = new CustmerLinkLIST();
                    custmerLinkLIST.AddEnd(56);
                    custmerLinkLIST.AddEnd(30);
                    custmerLinkLIST.AddEnd(70);

                    custmerLinkLIST.Display();
                    break;
            }


               
          //CustmerLinkLIST custmerLinkLIST = new CustmerLinkLIST();
          //  custmerLinkLIST.AddEnd(56);
          //  custmerLinkLIST.AddEnd(30);
          //  custmerLinkLIST.AddEnd(70);
            
          //  Console.WriteLine("element add after the head node");
          //  custmerLinkLIST.Display();

          //  CustmerLinkLIST custmerLinkLIST1 = new CustmerLinkLIST();
          //  custmerLinkLIST1.AddFirst(11);
          //  custmerLinkLIST1.AddFirst(12);
          //  custmerLinkLIST1.AddFirst(13);
          //  custmerLinkLIST1.AddFirst(14);
          //  Console.WriteLine("element add before the head node");
          //  custmerLinkLIST1.Display();
        }
    }
}