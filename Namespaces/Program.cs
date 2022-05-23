//C# program to illustrate the
//use of namespaces

using System;

//Namespace declaration
namespace Namespaces
{
    class Geeks_1
    {
        //funtion of class Geeks_1
        public static void dispaly()
        {

            /**
             * Here System is the namespace
             * under which console class is defined
             * you can avoid writing stsem with 
             * the help of "using" keyword **/
            Console.WriteLine("HELLO FENTSE");
            //or
            System.Console.WriteLine("Hey fentse");
            Console.ReadKey();  
        }
    }
}//ending of namespace

//Class Declaration

class geeks_2
{

    //Main method

   public  static void Main(string[] args)
    {
        //Calling the display method of
        //class Geeks_2 by using two dot
        //operator as one is use to access
        //the class of the first namespace and
        //another is use to access the static method of class Geeeks_1
        //termed as fully qualified name
        Namespaces.Geeks_1.dispaly();


    
    }
}
