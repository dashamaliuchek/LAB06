using LAB06;

namespace LAB06
{
    class Program
    {
        static void Main()
        {

            Person p1 = new Person();
            Person p2 = new Person("Алексей");
            Person p3 = new Person("Алексей", 20);
            Person p4 = new Person("Алексей", 20, "Москва");

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
        }
    }
}
