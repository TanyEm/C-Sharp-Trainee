using System;

namespace C_Sharp_Trainee
{
    public class ClassA : ClassB
    {
        // The subclass method has the same name as superclass method.
        // The method will be running because subclass has priority
        public void Display1()
        {
            System.Console.WriteLine("ClassA Display1");
            //base can be used to refer to methods of the superclass
            base.Display1();
        }

    }

    public class ClassB
    {
        public int x = 100;
        public void Display1()
        {
            Console.WriteLine("ClassB Display1");
        }
        public void Display2()
        {
            Console.WriteLine("ClassB Display2");
        }
    }
}
