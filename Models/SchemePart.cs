namespace FitNet.Models;

public class SchemePart
{
    public long Id { get; set; }
    public string Name { get; set; }

    public Scheme Scheme;
    public ICollection<Exercise> Exercises;
}
