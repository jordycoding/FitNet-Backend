namespace FitNet.Models;

public class Scheme
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }

    public ICollection<SchemePart> SchemeParts;
}
