using System;



namespace Pass_By_Value
{
    class Pass_By_Value
    {
        public void swap(int x, int y)
        {
            int temp;

            temp = x; 
            x = y;    
            y = temp; 
            Console.WriteLine("In swap function, value of a : {0}", x);
            Console.WriteLine("In swap function, value of b : {0}", y);
        }
        static void Main(string[] args)
        {
            Pass_By_Value n = new Pass_By_Value();

            /* local variable definition */
            int a = 500;
            int b = 800;

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);

            /* calling a function to swap the values */
            n.swap(a, b);

            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);

            Console.ReadLine();
        }
    }
}


