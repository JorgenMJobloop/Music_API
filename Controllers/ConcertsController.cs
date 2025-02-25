using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/concerts")]
public class ConcertsController : ControllerBase
{
    private readonly AppDbContext _context;

    private List<Concerts> concertsList = new List<Concerts>() {
        new Concerts {Location = ["New York"], Venues = ["Concert Hall"], Groups = ["Gorillaz"], EventDates = DateTime.Now}
    };

    public ConcertsController(AppDbContext context)
    {
        _context = context;
        if (!_context.concerts.Any())
        {
            _context.AddRange(concertsList);
            _context.SaveChanges();
        }
    }

    [HttpGet]
    public IEnumerable<Concerts> Get()
    {
        return _context.concerts.ToList();
    }
}