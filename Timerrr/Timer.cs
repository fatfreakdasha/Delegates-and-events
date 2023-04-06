using System;
using System.Threading;

class Timer 
{
    private int Hours;
    private int Minutes;
    private int Seconds; 

    public Timer(int hours, int minutes, int seconds) 
    {
        Hours = hours;
        Minutes = minutes; 
        Seconds = seconds;
    }

    public void Start() 
    {
        int totalSeconds = Hours * 3600 + Minutes * 60 + Seconds; 
        
        for (int i = totalSeconds; i >= 0; i--)  
        {
            int h = i / 3600;
            int m = (i % 3600) / 60;
            int s = i % 60;

            Console.WriteLine("{0:00}:{1:00}:{2:00}", h, m, s); 

            Thread.Sleep(1000); 
        }

        Console.WriteLine("таймер завершен"); 
    }
}