using System;

// WorkoutLog 1
WorkoutLog workout1 = new();

int[] inputs = { 30, 45, 0, 25, 60, 20 };

foreach (int minutes in inputs)
{
    Console.WriteLine(workout1.AddWorkout(minutes));
}

Console.WriteLine("Total: " + workout1.GetTotalMinutes());
Console.WriteLine("Average: " + workout1.GetAverageMinutes());
Console.WriteLine("Longest: " + workout1.GetLongestWorkout());

// WorkoutLog 2
WorkoutLog workout2 = new();

Console.WriteLine("Second workout log:");
Console.WriteLine("Total: " + workout2.GetTotalMinutes());
Console.WriteLine("Average: " + workout2.GetAverageMinutes());
Console.WriteLine("Longest: " + workout2.GetLongestWorkout());

public class WorkoutLog
{
    //fields
    public int[] Durations = new int[5];
    public int Count = 0;

    //methods
    public bool AddWorkout(int minutes)
    {
        if (minutes > 0 && this.Count < 5)
        {
            this.Durations[this.Count] = minutes;
            Count++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public int GetTotalMinutes()
    {
        int totalMinutes = 0;

        for (int duration = 0; duration < Count; duration++)
        {
            int mins = Durations[duration];
            totalMinutes += mins;
        }
        return totalMinutes;
    }

    public int GetAverageMinutes()
    {
        if (this.Count == 0)
        {
            return 0;
        }
        else
        {
            return GetTotalMinutes() / this.Count;
        }
    }

    public int GetLongestWorkout()
    {
        int longestMins = 0;
        if (this.Count == 0)
        {
            return 0;
        }
        for (int maxDuration = 0; maxDuration < Count; maxDuration++)
        {
            int maxMins = Durations[maxDuration];
            if (maxMins > longestMins)
            {
                longestMins = maxMins;
            }
        }
        return longestMins;
    }
}