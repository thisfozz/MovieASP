using MovieASP.DataAccess.Entities;

namespace MovieASP.DataAccess.Repositories;

public class MovieRepository : IMovieRepository
{

    private readonly List<MovieEntity> _movie =
    [
        new MovieEntity
        {
            Id = 1,
            Title = "Майор Гром: Игра",
            Director = "Олег Трофим",
            Genre = "боевик, приключения",
            Image = "/img/majorGrom.jpg",
            Description = "Майор полиции Игорь Гром известен всему Санкт-Петербургу пробивным характером и непримиримой позицией по отношению к преступникам всех мастей. Неимоверная сила, аналитический склад ума и неподкупность — всё это делает майора Грома самым настоящим супергероем. Его жизнь идеальна: днём он ловит преступников вместе с напарником Димой Дубиным, а вечера проводит в компании журналистки Юлии Пчёлкиной. Полную идиллию прерывает появление в городе таинственного злодея, называющего себя Призраком. Он предлагает Грому сыграть в опасную игру, ставка в которой — жизни обычных людей.",
            Sessions = new List<SessionEntity>
            {
                new SessionEntity { Id = 1, Time = DateTime.Parse("2024-06-19 11:20"), CinemaId = 1 },
                new SessionEntity { Id = 2, Time = DateTime.Parse("2024-06-19 14:45"), CinemaId = 1 },
                new SessionEntity { Id = 2, Time = DateTime.Parse("2024-06-19 18:05"), CinemaId = 1 },
                new SessionEntity { Id = 2, Time = DateTime.Parse("2024-06-19 21:25"), CinemaId = 1 }
            }
        },
        new MovieEntity
        {
            Id = 2,
            Title = "Министерство неджентльменских дел",
            Director = "Гай Ричи",
            Genre = "боевик, драма, военный, история",
            Image = "/img/ministerstvo.jpg",
            Description = "1942 год, Великобритания. Они — лучшие из лучших. Отпетые авантюристы и первоклассные спецы, привыкшие действовать в одиночку. Но когда на кону стоит судьба всего мира, им приходится объединиться в сверхсекретное боевое подразделение и отправиться на выполнение дерзкой миссии против нацистов. Теперь их дело — война, и вести они её будут совершенно не по-джентльменски.",
            Sessions = new List<SessionEntity>
            {
                new SessionEntity { Id = 2, Time = DateTime.Parse("2024-06-19 16:10"), CinemaId = 2 },
                new SessionEntity { Id = 2, Time = DateTime.Parse("2024-06-19 21:25"), CinemaId = 2 }
            }
        },
        new MovieEntity
        {
            Id = 3,
            Title = "Непослушники",
            Director = "Владимир Котт",
            Genre = "комедия",
            Image = "/img/neposlush.jpg",
            Description = "Дима уже не Димонстр, а вполне успешный менеджер по продажам в автосалоне, Саша Чёрный — добропорядочный монах в тихой обители отца Анатолия. Все живут спокойно, пока в монастырь не привозят четырех детдомовских непослушников: двух братьев и двух сестёр. Из-за неоднократных побегов и мелких краж ребят могут отправить в место куда более суровое, чем детский дом. Следователь не хочет ломать им жизнь и даёт последний шанс: привозит к отцу Анатолию, надеясь, что если тому удалось перевоспитать Димонстра и Сашу Чёрного, то и детей получится.",
            Sessions = new List<SessionEntity>
            {
                new SessionEntity { Id = 3, Time = DateTime.Parse("2024-06-19 11:00"), CinemaId = 1 },
                new SessionEntity { Id = 3, Time = DateTime.Parse("2024-06-19 13:45"), CinemaId = 1 },
                new SessionEntity { Id = 3, Time = DateTime.Parse("2024-06-19 16:50"), CinemaId = 1 },
                new SessionEntity { Id = 3, Time = DateTime.Parse("2024-06-19 20:35"), CinemaId = 1 }
            }
        },
        new MovieEntity
        {
            Id = 4,
            Title = "Игры разума",
            Director = "Рон Ховард",
            Genre = "биография, драма",
            Image = "/img/igrirazuma.jpg",
            Description = "От всемирной известности до греховных глубин — все это познал на своей шкуре Джон Форбс Нэш-младший. Математический гений, он на заре своей карьеры сделал титаническую работу в области теории игр, которая перевернула этот раздел математики и практически принесла ему международную известность. Однако буквально в то же время заносчивый и пользующийся успехом у женщин Нэш получает удар судьбы, который переворачивает уже его собственную жизнь.",
            Sessions = new List<SessionEntity>
            {
                new SessionEntity { Id = 4, Time = DateTime.Parse("2024-06-19 10:30"), CinemaId = 1 },
                new SessionEntity { Id = 4, Time = DateTime.Parse("2024-06-19 14:15"), CinemaId = 1 },
                new SessionEntity { Id = 4, Time = DateTime.Parse("2024-06-19 17:45"), CinemaId = 1 },
                new SessionEntity { Id = 4, Time = DateTime.Parse("2024-06-19 21:00"), CinemaId = 1 }
            }
        },
        new MovieEntity
        {
            Id = 5,
            Title = "Бойцовский клуб",
            Director = "Дэвид Финчер",
            Genre = "драма, триллер",
            Image = "/img/boytsclub.jpg",
            Description = "Сотрудник страховой компании страдает хронической бессонницей и отчаянно пытается вырваться из мучительно скучной жизни. Однажды в очередной командировке он встречает некоего Тайлера Дёрдена — харизматического торговца мылом с извращенной философией. Тайлер уверен, что самосовершенствование — удел слабых, а единственное, ради чего стоит жить, — саморазрушение. Проходит немного времени, и вот уже новые друзья лупят друг друга почем зря на стоянке перед баром, и очищающий мордобой доставляет им высшее блаженство. Приобщая других мужчин к простым радостям физической жестокости, они основывают тайный Бойцовский клуб, который начинает пользоваться невероятной популярностью.",
            Sessions = new List<SessionEntity>
            {
                new SessionEntity { Id = 5, Time = DateTime.Parse("2024-06-19 12:00"), CinemaId = 2 },
                new SessionEntity { Id = 5, Time = DateTime.Parse("2024-06-19 15:15"), CinemaId = 2 },
                new SessionEntity { Id = 5, Time = DateTime.Parse("2024-06-19 18:30"), CinemaId = 2 },
                new SessionEntity { Id = 5, Time = DateTime.Parse("2024-06-19 21:45"), CinemaId = 2 },
                new SessionEntity { Id = 5, Time = DateTime.Parse("2024-06-19 23:30"), CinemaId = 2 }
            }
        },
        new MovieEntity
        {
            Id = 6,
            Title = "Джентельмены",
            Director = "Гай Ричи",
            Genre = "боевик, комедия, криминал",
            Image = "/img/djentelman.jpg",
            Description = "Один ушлый американец ещё со студенческих лет приторговывал наркотиками, а теперь придумал схему нелегального обогащения с использованием поместий обедневшей английской аристократии и очень неплохо на этом разбогател. Другой пронырливый журналист приходит к Рэю, правой руке американца, и предлагает тому купить киносценарий, в котором подробно описаны преступления его босса при участии других представителей лондонского криминального мира — партнёра-еврея, китайской диаспоры, чернокожих спортсменов и даже русского олигарха.",
            Sessions = new List<SessionEntity>
            {
                new SessionEntity { Id = 6, Time = DateTime.Parse("2024-06-19 10:45"), CinemaId = 2 },
                new SessionEntity { Id = 6, Time = DateTime.Parse("2024-06-19 14:00"), CinemaId = 2 },
                new SessionEntity { Id = 6, Time = DateTime.Parse("2024-06-19 17:15"), CinemaId = 2 },
                new SessionEntity { Id = 6, Time = DateTime.Parse("2024-06-19 20:30"), CinemaId = 2 }
            }
        },
        new MovieEntity
        {
            Id = 7,
            Title = "Мстители: Война Бесконечности",
            Director = "Энтони Руссо, Джо Руссо",
            Genre = "фантастика, боевик, приключения",
            Image = "/img/mstiteli.jpg",
            Description = "Пока Мстители и их союзники продолжают защищать мир от различных опасностей, с которыми не смог бы справиться один супергерой, новая угроза возникает из космоса: Танос. Межгалактический тиран преследует цель собрать все шесть Камней Бесконечности - артефакты невероятной силы, с помощью которых можно менять реальность по своему желанию. Всё, с чем Мстители сталкивались ранее, вело к этому моменту – судьба Земли никогда ещё не была столь неопределённой.",
            Sessions = new List<SessionEntity>
            {
                new SessionEntity { Id = 7, Time = DateTime.Parse("2024-06-19 11:00"), CinemaId = 1 },
                new SessionEntity { Id = 7, Time = DateTime.Parse("2024-06-19 13:45"), CinemaId = 1 },
                new SessionEntity { Id = 7, Time = DateTime.Parse("2024-06-19 16:30"), CinemaId = 1 },
                new SessionEntity { Id = 7, Time = DateTime.Parse("2024-06-19 19:15"), CinemaId = 1 },
                new SessionEntity { Id = 7, Time = DateTime.Parse("2024-06-19 22:00"), CinemaId = 1 },
            }
        },
        new MovieEntity
        {
            Id = 8,
            Title = "Мстители: Финал",
            Director = "Энтони Руссо, Джо Руссо",
            Genre = "фантастика, боевик, драма, приключения",
            Image = "/img/final.jpg",
            Description = "Оставшиеся в живых члены команды Мстителей и их союзники должны разработать новый план, который поможет противостоять разрушительным действиям могущественного титана Таноса. После наиболее масштабной и трагической битвы в истории они не могут допустить ошибку.",
            Sessions = new List<SessionEntity>
            {
                new SessionEntity { Id = 8, Time = DateTime.Parse("2024-06-19 10:30"), CinemaId = 1 },
                new SessionEntity { Id = 8, Time = DateTime.Parse("2024-06-19 12:15"), CinemaId = 1 },
                new SessionEntity { Id = 8, Time = DateTime.Parse("2024-06-19 13:35"), CinemaId = 1 },
                new SessionEntity { Id = 8, Time = DateTime.Parse("2024-06-19 16:50"), CinemaId = 1 },
                new SessionEntity { Id = 8, Time = DateTime.Parse("2024-06-19 19:20"), CinemaId = 1 },
                new SessionEntity { Id = 8, Time = DateTime.Parse("2024-06-19 21:00"), CinemaId = 1 },
                new SessionEntity { Id = 8, Time = DateTime.Parse("2024-06-19 23:45"), CinemaId = 1 },
            }
        }
    ];

    public List<MovieEntity> GetAll()
    {
        return _movie;
    }

    public MovieEntity GetById(int id)
    {
        return _movie.FirstOrDefault(m => m.Id == id);
    }

    public void Create(MovieEntity model)
    {
        _movie.Add(model);
    }

    public void Delete(int id)
    {
        var entity = GetById(id);
        if (entity == null) return;
        _movie.Remove(entity);
    }

    public void Update(MovieEntity model)
    {
        var index = _movie.FindIndex(m => m.Id == model.Id);
        if (index == -1) return;

        _movie[index].Title = model.Title;
        _movie[index].Director = model.Director;
        _movie[index].Genre = model.Genre;
        _movie[index].Description = model.Description;
        _movie[index].Sessions = model.Sessions;
    }
}