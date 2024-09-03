using System;
using System.Threading;


class Program
{
    static void Main()
    {
        Thread thread1 = new Thread(Method1);
        Thread thread2 = new Thread(Method2);
        thread1.Start();
        thread2.Start();
    }

    static void Method1()
    {
        for (int i = 0; i<8; i++)
        {
        Console.WriteLine("Thread1: "+i);
        Thread.Sleep(1000);
        }
    }
    
    static void Method2()
    {
        for (int y = 0;y<8; y++)
        {
        Console.WriteLine("Thread2: "+y);
        Thread.Sleep(1000);
        }
    }
}
