using MovieASP.DataAccess.Entities;
using MovieASP.Models;

namespace MovieASP.DataAccess.Repositories;

public interface IMovieRepository
{
    List<MovieModel> GetAll();
    MovieModel GetById(int id);

    void Create(MovieModel model);
    void Update(MovieModel model);
    void Delete(int id);
}