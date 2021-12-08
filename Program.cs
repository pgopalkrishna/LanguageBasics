using System;

namespace LanguageBasics
{
    class Program
    {
        public delegate int mydel(int a,int b);
        delegate void DelOp(int x, int y);
        delegate void Del_Anonymous();
        
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Simple delegate=>");
        //    mydel del1 = MyCal.SumNumbers;
        //    mydel del2 = MyCal.Multiplication;

        //   // del1(2, 4);
        //    Console.WriteLine(del1(2, 4));
        //   // del1(8, 5);
        //    Console.WriteLine(del2(8, 5));
        //    // Console.WriteLine("Multiplication of a:{0} and b:{1} is :{2}", a, b, (a * b));

        //    //Array of delegates:
        //    // Delegate instantiation  
        //    DelOp[] obj =
        //   {
        //       new DelOp(Operation.Add),
        //       new DelOp(Operation.Multiple)
        //   };
        //    Console.WriteLine("Array of delegate=>");
        //    for (int i = 0; i < obj.Length; i++)
        //    {
        //        obj[i](2, 5);
        //        obj[i](8, 5);
        //        obj[i](4, 6);
        //    }
        //    //Multicast delegate
        //    DelOp Multicast_Obj = Operation.Add;
        //    Multicast_Obj += Operation.Multiple;
        //    Console.WriteLine("Multicast delegate=>");
        //    Multicast_Obj(9, 1);
        //    Multicast_Obj(9, 9);
        //    Multicast_Obj -= Operation.Multiple;
        //    Console.WriteLine("Multicast delegate after unsubscribing Multiple method =>");
        //    Multicast_Obj(9, 1);
        //    Multicast_Obj(9, 9);

        //    //anonymous delegate
        //    Del_Anonymous obj_anonymous = delegate
        //    {
        //        Console.WriteLine("Hello from anonymous delegate method");
        //    };
        //    obj_anonymous();
        //    Console.ReadLine();
        //}
    }
    public static class MyCal 
    {
        public static int SumNumbers(int a, int b) {
            return a + b;
        }
        public static int Multiplication(int a, int b) {
            return a * b;
        }
    }
    public class Operation
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition={0}", a + b);
        }

        public static void Multiple(int a, int b)
        {
            Console.WriteLine("Multiply={0}", a * b);
        }
    }
}
