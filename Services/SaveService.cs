using System;
using MaINTestEnv.Models;
using Microsoft.IdentityModel.Tokens;

namespace MaINTestEnv.Services;

public class SaveService
{
	private readonly List<Save> saves = [];

	public Save[]? GetSaves() => saves.ToArray();
	public void CreateSave(string adventureName, string generatedAdventure, GameSettings gameSettings)
	{
		Save save = new()
		{
			Id = Guid.NewGuid(),
			AdventureName = adventureName,
			GeneratedAdventure = generatedAdventure,
			GameSettings = gameSettings
		};

		saves.Add(save);
	}

	public void DeleteSave(Guid id)
	{
		Save save = saves.Find(s => s.Id == id) ?? throw new ArgumentNullException("Game not found");

		saves.Remove(save);
	}
}
