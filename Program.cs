using System;

namespace U3_programa4
{
    class Program
    {
        static void Main(string[] args)
        { float n1,n2,n3,n4;
            Console.WriteLine("ingrese un número por favor");
            n1=float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro número por favor");
            n2=float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro número por favor");
            n3=float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el último número por favor");
            n4=float.Parse(Console.ReadLine());

            if (n1>n2 && n1>n3 && n1>n4 )
            {
                Console.WriteLine( n1 +" es el mayor");
            }else if(n2>n1 && n2>n3 && n2>n4 ){
                Console.WriteLine( n2 +" es el mayor");
            }else if(n3>n1 && n3>n2 && n3>n4){
                Console.WriteLine( n3 +" es el mayor");
            }else{
                Console.WriteLine( n4 +" es el mayor");
            }

        }
    }
}
