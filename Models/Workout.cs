namespace FitNet.Models;

public class Workout
{
    public long Id { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }

    public User User;
    public ICollection<WorkoutEntry>? WorkoutEntries { get; set; }
}
