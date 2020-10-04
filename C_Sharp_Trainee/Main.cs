using System;
namespace C_Sharp_Trainee
{
    class MainOOP
    {
        static void Main(string[] args)
        {
            //Overload overload = new Overload();
            //overload.DisplayOverload(100);
            //overload.DisplayOverload("method overloading");
            //overload.DisplayOverload("method overloading", 100);

            //overload.Display();

            //object[] objArray = { 100, "Akhil", 200.300 }; //Array 
            //object obj = objArray; //Array as an object
            //Console.WriteLine("Array");
            //Overload.Display(objArray);
            //Console.WriteLine("Array cast to object");
            //Overload.Display((object)objArray);
            //Console.WriteLine("Array as an object");
            //Overload.Display(obj);
            /////Let's go deeper :D
            //Console.WriteLine("Array as an object which cast to object");
            //Overload.Display((object[])obj);

            ClassA a = new ClassA();
            a.Display1();
            Console.ReadKey();
        }
    }
}
