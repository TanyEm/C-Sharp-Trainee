using System;
namespace C_Sharp_Trainee
{
    class MainOOP
    {
        static void Main(string[] args)
        {
            //Just to understand what overload is
            Overload overload = new Overload();
            overload.DisplayOverload(100);
            overload.DisplayOverload("method overloading");
            overload.DisplayOverload("method overloading", 100);
            overload.Display();

            // More about overload and C# params
            // More about references and values
            object[] objArray = { 100, "Akhil", 200.300 }; //Array 
            object obj = objArray; //Array as an object
            Console.WriteLine("Array");
            Overload.Display(objArray);
            Console.WriteLine("Array cast to object");
            Overload.Display((object)objArray);
            Console.WriteLine("Array as an object");
            Overload.Display(obj);
            ///Let's go deeper :D
            Console.WriteLine("Array as an object which cast to object");
            Overload.Display((object[])obj);

            ClassA a = new ClassA();
            a.Display1();
            a.Display2();

            ClassB b = new ClassB();
            b.Display1();

            /*
             * Here more practice with polymorphism and inheritance
             * with virtual, override and new methods
             */
            FirstClass a = new SecondClass();
            FirstClass b = new ThirdClass();
            SecondClass c = new ThirdClass();

            Console.WriteLine("=================");
            a.AAA(); a.BBB(); a.CCC();
            Console.WriteLine(" ");

            b.AAA(); b.BBB(); b.CCC();
            Console.WriteLine(" ");

            c.AAA(); c.BBB(); c.CCC();
            Console.WriteLine("=================");

            Console.ReadKey();
        }
    }
}
