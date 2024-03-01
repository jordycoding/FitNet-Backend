namespace FitNet.Models;

public class User
{
    public string SubjectId { get; set; }

    public ICollection<Workout>? Workouts;
}
