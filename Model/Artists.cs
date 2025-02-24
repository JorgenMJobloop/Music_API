public class Artists
{
    public int ID { get; set; }
    public Guid guid { get; set; } = Guid.NewGuid();
    public string? Names { get; set; }
    public string? Genre { get; set; }
    public List<string>? Albums { get; set; }
    public string? ImageURL { get; set; }
}