using System;

namespace Exercise9
{

    class Program
    {
        static void Main(string[] args)
        {
            A[] v = new A[3];

            v[0] = new A(1);
            v[1] = new A(3);
            v[2] = new A(2);



            Array.Sort(v, delegate (A a, A b) { return a.N.CompareTo(b.N); });
            foreach (A item in v)
            {
                Console.WriteLine(item.N);

            }
        }
    }

    class A
    {
        
        public A(int n)
        {
            this.N = n;
        }

        public int N { get; }
    }

}
