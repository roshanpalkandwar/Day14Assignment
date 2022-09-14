namespace linkLIASt2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("chooes Number\n1.simple Linked List\n2.to create Linked");
            int opt=Convert.ToInt32(Console.ReadLine());
            switch(opt)
            {
                case 1:
                    CustmerLinkLIST custmerLinkLIST = new CustmerLinkLIST();
                    custmerLinkLIST.Add(56);
                    custmerLinkLIST.Add(30);
                    custmerLinkLIST.Add(70);

                    custmerLinkLIST.Display();
                    break;

                    case 2:
                    CustmerLinkLIST list2 = new CustmerLinkLIST();
                    list2.Add(70);
                    int a = list2.Search(70);
                    Console.WriteLine("index position of 70 is : " + a);
                    list2.InsertNthPosition(a + 1, 30);
                    list2.InsertNthPosition(a + 1, 56);
                    list2.Display();
                    Console.WriteLine("****Program End***\n");
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