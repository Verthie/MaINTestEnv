using System;
using MaINTestEnv.Models;
using Microsoft.IdentityModel.Tokens;

namespace MaINTestEnv.Services;

public class GameSettingsService
{
	private List<GameSettings>? gameSettings;

	//:TODO Retrieve, Add and Delete Functionality

	private GameSettings[]? GetGameSettings() => gameSettings.IsNullOrEmpty() ? null : gameSettings!.ToArray();
}
