using System;

namespace MaINTestEnv.Models;

public class Save
{
    public Guid Id { get; set; }
    public required string AdventureName { get; set; }
    public required string GeneratedAdventure { get; set; }
    public required GameSettings GameSettings { get; set; }

    //:TODO Add other properties (e.g. for storing past game events List<string>?, past player choices List<string>?, player state (player class), etc.)
}