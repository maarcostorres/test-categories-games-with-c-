using System;
using System.Collections.Generic;

// Classe base para jogos
abstract class Game
{
    public string Name { get; set; }
    public abstract void Play();
}

// Categoria de jogos de tabuleiro
class BoardGame : Game
{
    public int MinPlayers { get; set; }
    public int MaxPlayers { get; set; }

    public override void Play()
    {
        Console.WriteLine($"Jogando o jogo de tabuleiro {Name} com {MinPlayers}-{MaxPlayers} jogadores.");
    }
}

// Categoria de jogos de cartas
class CardGame : Game
{
    public int MinPlayers { get; set; }
    public int MaxPlayers { get; set; }
    public Deck Deck { get; set; }

    public override void Play()
    {
        Console.WriteLine($"Jogando o jogo de cartas {Name} com {MinPlayers}-{MaxPlayers} jogadores.");
        Console.WriteLine($"Usando um baralho de {Deck.Size} cartas.");
    }
}

// Classe para representar um baralho de cartas
class Deck
{
    public int Size { get; set; }

    public Deck(int size)
    {
        Size = size;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando instâncias dos jogos
        BoardGame monopoly = new BoardGame()
        {
            Name = "Monopoly",
            MinPlayers = 2,
            MaxPlayers = 6
        };

        CardGame poker = new CardGame()
        {
            Name = "Poker",
            MinPlayers = 2,
            MaxPlayers = 10,
            Deck = new Deck(52)
        };

        CardGame uno = new CardGame()
        {
            Name = "Uno",
            MinPlayers = 2,
            MaxPlayers = 10,
            Deck = new Deck(108)
        };

        // Criando uma lista de jogos
        List<Game> games = new List<Game>();
        games.Add(monopoly);
        games.Add(poker);
        games.Add(uno);

        // Jogando todos os jogos da lista
        foreach (Game game in games)
        {
            game.Play();
        }
    }
}
