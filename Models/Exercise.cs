namespace FitNet.Models;

public class Exercise
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }

    public ICollection<Muscle>? Muscles { get; set; }
}
