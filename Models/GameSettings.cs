using System;
using System.ComponentModel.DataAnnotations;

namespace MaINTestEnv.Models;

public class GameSettings
{
	public int Id { get; set; }
	[Required(ErrorMessage = "Please enter your player name")]
	[StringLength(20)]
	public required string PlayerName { get; set; }
	// [Required(ErrorMessage = "Choose the setting for your adventure")]
	[Required(ErrorMessage = "The length of an adventure must be between 10 and 100")]
	[Range(10, 100)]
	public int AdventureLength { get; set; } = 20; // The amount of in-game events that will happen, before reaching the end of the game
	public bool IsCustom { get; set; } = false;
	public string AdventureSetting { get; set; } = "";
	// [Required(ErrorMessage = "Choose the type of your adventure")]
	public string GameType { get; set; } = "";
	public string CustomPrompt { get; set; } = "";
}