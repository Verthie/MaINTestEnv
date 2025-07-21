using System;

namespace MaINTestEnv.Models;

public class Save
{
    public int Id { get; set; }
    public required string AdventureName { get; set; }
    public required GameSettings GameSettings { get; set; }
    //:TODO Add other properties (e.g. for storing past game events List<string>?, past player choices List<string>?, player state (class), etc.)
}