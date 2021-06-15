using System;

namespace Exercise2
{
    class A
    {
        protected int n=1;
        public A()
        {
            n++;
            Console.WriteLine("n (A) = " +n.ToString());
          
        }

        public int N { get; set; }
    }
    class B : A
    {
        public B()
        {
            n = 10;
            Console.WriteLine("n (B) = " + n.ToString());
           
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            A a = new B();
           
        }
    }

}
