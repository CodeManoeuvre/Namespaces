using System;

namespace NestedNamespace
{

    //Memeber declaration & definitions
    namespace childnamespace
    {
        //class within nested namespace
        public class childclass
        {
            public static void display()
            {
                Console.WriteLine("hey fetse this is nested namespace");
                Console.ReadKey();


            }

            //constructor of nested 
            //names class childclass
            public childclass()
            {
                Console.WriteLine("Constructor");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                new NestedNamespace.childnamespace.childclass();
                NestedNamespace.childnamespace.childclass.display();

                Console.ReadKey();
            }
        }
    }
}