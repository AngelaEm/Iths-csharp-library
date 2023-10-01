namespace Iths_csharp_library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Välkommen Till Bibloteket****");
            Console.WriteLine("1 : Adding books");
            Console.WriteLine("2 : Removing Books");
            Console.WriteLine("3 : ChekingOut");
            Console.WriteLine("4 : Returning Books");

            string menyChoice = Console.ReadLine();

            switch (menyChoice)
            {
                case "1":
                    AddBooks();
                    break;
                case "2"
                    RemovingBooks();
                    break;
                case "3":
                    ChekingOut();
                    break;
                case "4":
                    ReturningBooks();
                    break;
                default:

                    break;

            }

        }

    }

}
    
