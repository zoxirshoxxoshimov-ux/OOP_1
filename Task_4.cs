using System;

// Create songs
Song song1 = new();
song1.Title = "Believer";
song1.DurationSeconds = 210;

Song song2 = new();
song2.Title = "Enemy";
song2.DurationSeconds = 185;

Song song3 = new();
song3.Title = "Numb";
song3.DurationSeconds = 240;

// Create first playlist
Playlist playlist1 = new();

playlist1.AddSong(song1);
playlist1.AddSong(song2);
playlist1.AddSong(song3);

// Play the second song twice
playlist1.PlaySong(1);
playlist1.PlaySong(1);

// Print song information
Console.WriteLine(song1.GetInfo());
Console.WriteLine(song2.GetInfo());
Console.WriteLine(song3.GetInfo());

// Print total duration
Console.WriteLine("Total duration: " +
    playlist1.GetTotalDuration() + " seconds");

// Create second playlist
Playlist playlist2 = new();

Console.WriteLine("Second playlist duration: " +
    playlist2.GetTotalDuration() + " seconds");

public class Song
{
    public string Title = "";
    public int DurationSeconds;
    public int PlayCount = 0;

    public void Play()
    {
        PlayCount++;
    }

    public string GetInfo()
    {
        return $"{Title} — {DurationSeconds} soniya, {PlayCount} marta ijro etildi";
    }
}

public class Playlist
{
    public Song[] Songs = new Song[5];
    public int Count = 0;

    public bool AddSong(Song song)
    {
        if (Count < 5)
        {
            Songs[Count] = song;
            Count++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool PlaySong(int index)
    {
        if (index < 0 || index >= Count)
        {
            return false;
        }

        Songs[index].Play();
        return true;
    }

    public int GetTotalDuration()
    {
        int totalDuration = 0;

        for (int i = 0; i < Count; i++)
        {
            totalDuration += Songs[i].DurationSeconds;
        }

        return totalDuration;
    }
}
