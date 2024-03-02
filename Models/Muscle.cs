namespace FitNet.Models;

public class Muscle
{
    public long Id { get; set; }
    public string Name { get; set; }

    public ICollection<Workout>? Workouts;
    public ICollection<MuscleGroup>? MuscleGroups;
    public ICollection<Exercise>? Exercises;
}
