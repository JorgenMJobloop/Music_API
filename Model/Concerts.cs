public class Concerts
{
    public int ID { get; set; }
    public Guid guid { get; set; } = Guid.NewGuid();
    public List<string>? Location { get; set; }
    public List<string>? Venues { get; set; }
    public List<string>? Groups { get; set; }
    public DateTime EventDates { get; set; }

    public int IncrementID()
    {
        return ID += 1;
    }
}