using System;
using MaINTestEnv.Models;
using Microsoft.IdentityModel.Tokens;

namespace MaINTestEnv.Services;

public class SaveService
{
	private List<Save>? saves;

	//:TODO Retrieve, Add and Delete Functionality

	private Save[]? GetSaves() => saves.IsNullOrEmpty() ? null : saves!.ToArray();
}
