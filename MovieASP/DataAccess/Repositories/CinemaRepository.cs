using MovieASP.DataAccess.Entities;

namespace MovieASP.DataAccess.Repositories;

public class CinemaRepository : ICinemaRepository
{
    private List<CinemaEntity> _cinemas = new List<CinemaEntity>
    {
        new CinemaEntity { Id = 1, Name = "Каро", Location = "ул. Московский тракт, 118" },
        new CinemaEntity { Id = 2, Name = "Синема Парк", Location = "ул. Максима Горького, 70" }
    };

    public CinemaEntity[] GetAll()
    {
        return _cinemas.ToArray();
    }

    public CinemaEntity GetById(int id)
    {
        return _cinemas.FirstOrDefault(c => c.Id == id);
    }
}