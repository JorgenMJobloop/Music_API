using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("api/artists")]
public class ArtistsController : ControllerBase
{
    private readonly AppDbContext _context;


    private List<Artists> _artists = new List<Artists>() {

        new Artists { ID = 1, guid = Guid.NewGuid(), Names = "The Cure", Genre = "Post-punk", Albums = ["Three Imaginary Boys", "Seventeen Seconds", "Faith", "Pornography", "The Top", "The Head On The Door", "Kiss Me, Kiss Me, Kiss Me", "Disintegration", "Wish", "Wild Mood Swings", "Bloodflowers", "The Cure", "4:13 Dream", "Songs of a Lost World"], ImageURL = "localhost:5191/images/thecure.jpg"}
    };

    public ArtistsController(AppDbContext context)
    {
        _context = context;
        if (!_context.Artists.Any())
        {
            _context.AddRange(_artists);
            _context.SaveChanges();
        }
    }

    // Create our GET endpoint, and implment a IEnumerable method
    [HttpGet]
    public IEnumerable<Artists> Get()
    {
        return _context.Artists.ToList();
    }

    // Create our POST endpoint, with support for extending our data model(s)
    [HttpPost]
    public IActionResult Post([FromBody] Artists artists)
    {
        _context.Add(artists);
        _context.SaveChanges();

        return CreatedAtAction(nameof(Post), new { id = artists.ID, names = artists.Names, genre = artists.Genre, albums = artists.Albums }, artists);
    }
}