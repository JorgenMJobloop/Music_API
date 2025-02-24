using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/testing/testmodel")]
public class TestModelController : ControllerBase
{
    private readonly AppDbContext _context;

    private static List<TestModel> testModel = new List<TestModel>() {
        new TestModel { ID = 1, guid = Guid.NewGuid(), Data = "Test ran successfully", TestLists = ["Test", "ran", "successfully"] },
        new TestModel { ID = 2, guid = Guid.NewGuid(), Data = "Test ran successfully", TestLists = ["", ""]}
    };

    public TestModelController(AppDbContext context)
    {
        _context = context;
        if (!_context.TestModel.Any())
        {
            _context.AddRange(testModel);
            _context.SaveChanges();
        }
    }

    [HttpGet]
    public IEnumerable<TestModel> TestGet()
    {
        return _context.TestModel.ToList();
    }
}