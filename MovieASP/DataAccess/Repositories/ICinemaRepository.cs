using MovieASP.DataAccess.Entities;

namespace MovieASP.DataAccess.Repositories;

public interface ICinemaRepository
{
    CinemaEntity[] GetAll();
    CinemaEntity GetById(int id);
}