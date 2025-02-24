﻿using System;
using static Move;

int wins = 0;
int draws = 0;
int loses = 0;
while (true)
{
	Console.Clear();
	Console.WriteLine("Mini Game 01 - Rock, Paper, and Scissors!");
	Console.WriteLine();

	Console.WriteLine("Your next move, choose one of the following:");
    Console.WriteLine("     [1]: rock");
    Console.WriteLine("     [2]: paper");
    Console.WriteLine("     [3]: scissors");
    Console.WriteLine("     [9]: exit");
    Console.WriteLine();
GetPlayerMoveInput:
	Move playerMove;
	switch ((Console.ReadLine() ?? "").Trim().ToLower())
	{
		case "1": playerMove = Rock; break;
		case "2": playerMove = Paper; break;
		case "3": playerMove = Scissors; break;
		case "9": Console.Clear(); return;
		default: Console.WriteLine("Invalid Input. Valid input is 1, 2, 3, or 9. Please Try Again..."); goto GetPlayerMoveInput;
	}
    Console.WriteLine($"You chose {playerMove}."); 
	Move computerMove = (Move)Random.Shared.Next(3);
	Console.WriteLine($"The computer chose {computerMove}.");
    Console.WriteLine();
	switch (playerMove, computerMove)
	{
		case (Rock, Paper) or (Paper, Scissors) or (Scissors, Rock):
			Console.WriteLine("You lose.");
			loses++;
			break;
		case (Rock, Scissors) or (Paper, Rock) or (Scissors, Paper):
			Console.WriteLine("You win.");
			wins++;
			break;
		default:
			Console.WriteLine("This game was a draw.");
			draws++;
			break;
	}
    Console.WriteLine($"=====================================");
	Console.WriteLine($"Score: {wins} wins, {loses} loses, {draws} draws");
    Console.WriteLine();
	Console.WriteLine("Press Enter To Continue...");
	Console.ReadLine();
}

enum Move
{
	Rock = 0,
	Paper = 1,
	Scissors = 2,
}
