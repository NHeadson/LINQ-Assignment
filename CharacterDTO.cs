public class CharacterDTO
{
  public UInt64 Id { get; set; }
  public string? Name { get; set; }
  public List<string> Series { get; set; } = [];
  public string Display(object? name)
  {
    return $"Id: {Id}\nName: {Name}\nSeries: {string.Join(", ", Series)}\n";
  }

    internal string? Display()
    {
        throw new NotImplementedException();
    }
}
