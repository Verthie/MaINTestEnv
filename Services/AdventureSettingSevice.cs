using System;
using MaINTestEnv.Models;

namespace MaINTestEnv.Services;

public class AdventureSettingSevice
{
	private readonly AdventureSetting[] adventureSettings =
	[
		new AdventureSetting
		{
			Id = 1,
			Name = "Fantasy"
		},
		new AdventureSetting
		{
			Id = 2,
			Name = "Cyberpunk"
		},
		new AdventureSetting
		{
			Id = 3,
			Name = "Steampunk"
		},
		new AdventureSetting
		{
			Id = 4,
			Name = "Sci-Fi"
		},
	];

	public AdventureSetting[] GetAdventureSettings() => adventureSettings;
}
