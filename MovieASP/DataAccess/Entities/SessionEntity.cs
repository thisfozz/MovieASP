namespace MovieASP.DataAccess.Entities;

public class SessionEntity
{
    public int Id { get; set; }
    public DateTime Time { get; set; }
    public int CinemaId { get; set; }
}