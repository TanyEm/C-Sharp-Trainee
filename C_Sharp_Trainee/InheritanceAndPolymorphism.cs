using System;
namespace C_Sharp_Trainee
{
    public class FirstClass
    {
        public virtual void AAA()
        {
            Console.WriteLine("FirstClass AAA");
        }

        public virtual void BBB()
        {
            Console.WriteLine("FirstClass BBB");
        }

        public void CCC()
        {
            Console.WriteLine("FirstClass CCC");
        }
    }

    public class SecondClass : FirstClass
    {
        public override void AAA()
        {
            Console.WriteLine("SecondClass AAA");
        }

        public new void BBB()
        {
            Console.WriteLine("SecondClass BBB");
        }

        public void CCC()
        {
            Console.WriteLine("SecondClass CCC");
        }
    }
}
