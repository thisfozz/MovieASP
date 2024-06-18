using MovieASP.DataAccess.Entities;

namespace MovieASP.Models;

public class MovieModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Director { get; set; }
    public string Genre { get; set; }
    public string Image { get; set; }
    public string Description { get; set; }
    public List<SessionEntity> Sessions { get; set; }
}