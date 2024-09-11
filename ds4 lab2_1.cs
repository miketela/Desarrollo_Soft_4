using System;
using Lab2_1;

namespace Lab2_1
{
    public class program
    {

        private static void Main(string[] args)
        {
            Myclass.Valor = 1;
            console.WriteLine(myClass.Valor);

        }
    }
    public class Myclass
    {
    public static int Valor;
    }

}


Myclass object1 =  new Myclass();
object1.Name = "Fulano";
object1.age  = 2;
Myclass object2 = object1;