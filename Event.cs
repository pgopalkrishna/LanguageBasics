using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace LanguageBasics
{
    public delegate void DelEventHandler();

    class Event
    {
        public static event DelEventHandler add;

        //static void Main(string[] args)
        //{
        //    add += new DelEventHandler(USA);
        //    add += new DelEventHandler(India);
        //    add += new DelEventHandler(England);
        //    add.Invoke();
        //    // Initialise t as typeof string
        //    Type t = typeof(string);

        //    // Use Reflection to find about
        //    // any sort of data related to t
        //    Console.WriteLine("Name : {0}", t.Name);
        //    Console.WriteLine("Full Name : {0}", t.FullName);
        //    Console.WriteLine("Namespace : {0}", t.Namespace);
        //    Console.WriteLine("Base Type : {0}", t.BaseType);
        //    Console.WriteLine("******************************************************");
        //    // Declare Instance of class Assembly
        //    // Call the GetExecutingAssembly method
        //    // to load the current assembly
        //    Assembly executing = Assembly.GetExecutingAssembly();

        //    // Array to store types of the assembly
        //    Type[] types = executing.GetTypes();
        //    foreach (var item in types)
        //    {
        //        // Display each type
        //        Console.WriteLine("Class : {0}", item.Name);

        //        // Array to store methods
        //        MethodInfo[] methods = item.GetMethods();
        //        foreach (var method in methods)
        //        {
        //            // Display each method
        //            Console.WriteLine("--> Method : {0}", method.Name);

        //            // Array to store parameters
        //            ParameterInfo[] parameters = method.GetParameters();
        //            foreach (var arg in parameters)
        //            {
        //                // Display each parameter
        //                Console.WriteLine("----> Parameter : {0} Type : {1}",
        //                                        arg.Name, arg.ParameterType);
        //            }
        //        }
        //    }
        //    Console.ReadLine();
        //}
        static void USA()
        {
            Console.WriteLine("USA");
        }

        static void India()
        {
            Console.WriteLine("India");
        }

        static void England()
        {
            Console.WriteLine("England");
        }
    }
    class Student
    {

        // Properties definition
        public int RollNo
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        // No Argument Constructor
        public Student()
        {
            RollNo = 0;
            Name = string.Empty;
        }

        // Parameterised Constructor
        public Student(int rno, string n)
        {
            RollNo = rno;
            Name = n;
        }

        // Method to Display Student Data
        public void displayData()
        {
            Console.WriteLine("Roll Number : {0}", RollNo);
            Console.WriteLine("Name : {0}", Name);
        }
    }

}
