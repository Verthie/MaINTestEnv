using System;
using MaINTestEnv.Models;

namespace MaINTestEnv.Services;

public class GameTypeService
{
	private readonly GameType[] gameTypes =
	[
		new GameType
		{
			Id = 1,
			Name = "Action"
		},
		new GameType
		{
			Id = 2,
			Name = "Puzzle"
		},
		new GameType
		{
			Id = 3,
			Name = "Adventure"
		},
		new GameType
		{
			Id = 4,
			Name = "Detective"
		},
	];

	public GameType[] GetGameTypes() => gameTypes;
}
