using GamesApi.Models;
namespace GamesApi.Data;

public static class GamesStore {
    private static int _nextId = 5;
    public static List<Game> Games { get; } = new() {
        new Game {
            Id = 1,
            Title = "The Elder Scrolls IV: Oblivion",
            Genre = "RPG",
            ReleaseYear = 2006,
        },
        new Game {
            Id = 2,
            Title = "The Witcher 3: Wild Hunt",
            Genre = "RPG",
            ReleaseYear = 2015,
        },
        new Game {
            Id = 3,
            Title = "Grand Theft Auto: San Anreas",
            Genre = "Action-adventure",
            ReleaseYear = 2004,
        },
        new Game {
            Id = 4,
            Title = "Hollow Knight: Silksong ",
            Genre = "Metroidvania",
            ReleaseYear = 2025,
            IsFavourite = true,
        },
    };
    public static int NextId() => _nextId++;
}