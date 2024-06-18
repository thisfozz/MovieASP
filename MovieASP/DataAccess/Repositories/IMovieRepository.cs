using MovieASP.DataAccess.Entities;

namespace MovieASP.DataAccess.Repositories;

public interface IMovieRepository
{
    MovieEntity[] GetAll();
    MovieEntity GetById(int id);
}