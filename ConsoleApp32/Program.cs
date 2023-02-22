using System;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            byte n = byte.Parse(Console.ReadLine());
            int[] array = new int[n];
            //length это свойства класса Array для опр. размера массива 
            // цикл для заполнения ОМ с помощью метода SetValue 
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"array[{i}]= ");
                array.SetValue(int.Parse(Console.ReadLine()), i);
            }
            //цикл вывода эл. GetValue
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array.GetValue(i)}");

            }
            Console.WriteLine();
            // izmenenie poryadka raspoloжение ОМ в обр. порядке
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array [{i}]={array.GetValue(i)}");

            }
            //обнуление элементов в одномерных массивах 
            Console.Write($"\n");
            Array.Clear(array, 2, 4);
            foreach ( int el in array)
            {
                Console.Write($"{el}\t");
            }
            Console.Write($"\n");
            Array.Resize(ref array,15);
            foreach (int el in array)
            {
                Console.Write($"{el}\t");
            }




        }
    }
}
