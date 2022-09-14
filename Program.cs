namespace linkLIASt2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("chooes Number\n1.simple Linked List\n2.to create Linked\n3.List by appending\n4.Ability to insert\n5.Ability to delete the first element\n6.Ability to delete the last element\n7.Ability to search LinkedList\n8.Ability to insert 40 after 30\n9.Ability to delete 40 from the Linked");
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
                case 3:
                    CustmerLinkLIST list3 = new CustmerLinkLIST();

                    list3.Add(56);
                    list3.InsertAfter(30, 56);
                    list3.InsertAfter(70, 30);
                    Console.WriteLine("List after appending 30 and 70");
                    list3.Display();
                    Console.WriteLine("****Program End***\n");
                    break ;
                case 4:
                    CustmerLinkLIST list4 = new CustmerLinkLIST();
                    list4.Add(56);
                    list4.Add(70);
                    int a2 = list4.Search(70);
                    Console.WriteLine("index position of 70 is : " + a2);
                    list4.InsertNthPosition(a2 + 1, 30);
                    list4.Display();
                    Console.WriteLine("****Program End***\n");
                    break;
                case 5:
                    CustmerLinkLIST list5 = new CustmerLinkLIST();
                    list5.Add(56);
                    list5.Add(30);
                    list5.Add(70);
                    list5.Display();
                    list5.RemoveFirstNode();
                    Console.WriteLine("After removing first element");
                    list5.Display();
                    Console.WriteLine("****Program End***\n");
                    break;
                case 6:
                    CustmerLinkLIST list6 = new CustmerLinkLIST();
                    list6.Add(56);
                    list6.Add(30);
                    list6.Add(70);
                    list6.Display();
                    list6.RemoveLastNode();
                    Console.WriteLine("After removing last element");
                    list6.Display();
                    Console.WriteLine("****Program End***\n");
                    break;
                case 7:
                    CustmerLinkLIST list7 = new CustmerLinkLIST();
                    list7.Add(56);
                    list7.Add(30);
                    list7.Add(70);
                    int a3 = list7.Search(30);
                    Console.WriteLine("index position of 30 is : " + a3);
                    list7.Display();
                    Console.WriteLine("****Program End***\n");
                    break ;
                case 8:
                    CustmerLinkLIST list8 = new CustmerLinkLIST();
                    list8.Add(56);
                    list8.Add(30);
                    list8.Add(70);
                    list8.Display();
                    int a4 = list8.Search(30);
                    Console.WriteLine("index position of 30 is : " + a4);
                    list8.InsertAfter(40, 30);
                    Console.WriteLine("list after update");
                    list8.Display();
                    Console.WriteLine("****Program End***\n");
                    break;
                case 9:
                    CustmerLinkLIST list9 = new CustmerLinkLIST();
                    list9.Add(56);
                    list9.Add(30);
                    list9.Add(40);
                    list9.Add(70);
                    list9.Display();
                    list9.DeleteAnyElement(40);
                    Console.WriteLine("List after deletion of 40");
                    list9.Display();
                    Console.WriteLine("Size of Linked List is: " + list9.size());
                    Console.WriteLine("****Program End***\n");
                    break;
            }


               
          
        }
    }
}