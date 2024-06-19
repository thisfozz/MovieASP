using Microsoft.AspNetCore.Mvc;
using MovieASP.DataAccess.Entities;
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
    public IActionResult List()
    {
        ViewBag.Title = "Что мы показываем";
        return View("List", _movieRepository.GetAll());
    }

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
            Sessions = curentMovie.Sessions
        };

        return View("MovieDetails", movieModel);
    }

    [HttpGet("create")]
    public IActionResult Create()
    {
        return View("CreateMovie");
    }

    [HttpPost("create")]
    public IActionResult Create(MovieEntity movieModel)
    {
        _movieRepository.Create(movieModel);
        return RedirectToAction("List");
    }

    [HttpGet("edit")]
    public IActionResult Edit(int id)
    {
        var movie = _movieRepository.GetById(id);
        if (movie == null)
        {
            return NotFound();
        }

        var movieModel = new MovieModel
        {
            Id = movie.Id,
            Title = movie.Title,
            Director = movie.Director,
            Genre = movie.Genre,
            Description = movie.Description,
            Sessions = movie.Sessions,
        };

        return View("EditMovie", movieModel);
    }

    [HttpPost("edit")]
    public IActionResult Edit(MovieEntity movieModel)
    {
        _movieRepository.Update(movieModel);
        return RedirectToAction("List");
    }

    [HttpPost("delete")]
    public IActionResult Delete(int id)
    {
        _movieRepository.Delete(id);
        return RedirectToAction("List");
    }
}