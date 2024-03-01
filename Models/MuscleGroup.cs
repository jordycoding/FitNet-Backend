namespace FitNet.Models;

public class MuscleGroup
{
    public long id { get; set; }
    public string Name { get; set; }

    public ICollection<Muscle> Muscles;
}
