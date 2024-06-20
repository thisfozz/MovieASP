using MovieASP.DataAccess.Entities;

namespace MovieASP.DataAccess.Repositories;

public interface IMovieRepository
{
    List<MovieEntity> GetAll();
    MovieEntity GetById(int id);
    void Create(MovieEntity model);
    void Update(MovieEntity model);
    void Delete(int id);
}