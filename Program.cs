namespace Class_0327_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student joe = new Student(1,"AAA");
            Student jane = new Student(2, "BBB");


            Console.WriteLine(joe.GetStudent());
            Console.WriteLine(jane.GetStudent());

        }
    }
}
