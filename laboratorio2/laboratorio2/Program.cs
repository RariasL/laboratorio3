using System;

namespace Laboratorio21
{
    public class Program
    {
        public static void main()
        {
            MyClass.valor = 1;
            Console.WriteLine(MyClass.Valor);
        }
    }
    public class MyClass
    {
        public static int valor;
    }
}