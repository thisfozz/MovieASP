using Microsoft.AspNetCore.Mvc;
using MovieASP.DataAccess.Repositories;
using MovieASP.Models;

namespace MovieASP.Controllers;

[Route("movies")]
public class MovieController : Controller
{
    private readonly IMovieRepository _movieRepository;
    private readonly ICinemaRepository _cinemaRepository;

    public MovieController(IMovieRepository movieRepository, ICinemaRepository cinemaRepository)
    {
        _movieRepository = movieRepository;
        _cinemaRepository = cinemaRepository;
    }

    [Route("/")]
    [HttpGet("list")]
    public IActionResult List()
    {
        ViewBag.Title = "Что мы показываем";
        var viewModel = new MoviesModel
        {
            Movies = _movieRepository.GetAll()
        };
        return View(viewModel);
    }

    [HttpGet("movie")]
    public IActionResult GetById([FromQuery] int id)
    {
        var curentMovie = _movieRepository.GetById(id);
        ViewBag.Title = $"{curentMovie.Title}";

        if(curentMovie == null)
        {
            return NotFound();
        }

        var movieModel = new MovieModel
        {
            Id = curentMovie.Id,
            Title = curentMovie.Title,
            Director = curentMovie.Director,
            Genre = curentMovie.Genre,
            Image = curentMovie.Image,
            Description = curentMovie.Description,
            Sessions = curentMovie.Sessions,
        };

        return View("MovieDetails", movieModel);
    }
}