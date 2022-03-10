// See https://aka.ms/new-console-template for more information
//Console.Beep(57, 5000);
//Console.Beep(37, 5000);
//Console.Beep(57, 5000);
//Console.Beep(37, 5000);
//Console.Beep(57, 5000);
//Demo.Test();
class Demo
{
    public static void Test()
    {
        string[] cars = { "BMW", "Hundai", "Suzuki" };
        //for (int i = ; i >= 0; i--)
        //{
        //    //var car = cars[i];
        //    Console.WriteLine(car);
        //    car[i] = "xyz";
        //}
        foreach(var car in cars)
        {
            Console.WriteLine(car);
        }

        int[] array1 = { 2343, 765, 234, 7865, 222, 433 };
        Console.WriteLine("Unsorted Array: ");
        foreach(int i in array1)
        {
            Console.Write($"{i},");
        }
        Array.Sort(array1);
        Console.WriteLine("\n---------");
        Console.WriteLine("Sorted Array in Ascending : ");
        foreach (int i in array1)
        {
            
            Console.Write($"{i},");
        }
        Console.WriteLine("\n---------\n");

        Array.Reverse(array1);
        Console.WriteLine("\n---------");
        Console.WriteLine("Sorted Array in Decending: ");
        foreach (int i in array1)
        {

            Console.Write($"{i},");
        }
        Console.WriteLine("\n---------\n");
        Console.WriteLine("\n----Binary Search-----\n");
        var result=Array.BinarySearch(array1, 222);
        if (result > 0)
            Console.WriteLine("Found");
        else
            Console.WriteLine("Not Found");
        
    }
}
