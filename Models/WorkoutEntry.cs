namespace FitNet.Models;

public class WorkoutEntry
{
    public long Id { get; set; }
    public float Weight { get; set; }
    public int Repetitions { get; set; }

    public Exercise Exercise { get; set; }
}
