﻿void Start(int time)
{
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Finished stopwatch!");
    Thread.Sleep(2500);
}

void Menu(){
    Console.Clear();
    Console.WriteLine("S - Seconds");
    Console.WriteLine("M = Minutes");
    Console.WriteLine("0 = Exit");
    Console.WriteLine("How long do you want to count?");
}

Menu();