﻿namespace TriviaGame;

class Player
{
    public string Name;
    public int Score;

    public Player(string playerName)
    {
        Name = playerName;
        Score = 0;
    }
}