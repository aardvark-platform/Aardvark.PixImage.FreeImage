﻿using System.IO;
using System.Reflection;

namespace FreeImageNETUnitTest
{
    public static class Utility
	{
		public static string GetExecutingFolder()
		{
			return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Locati‌​on);
		}

		public static string GetSolutionFolder()
		{
			// TODO: this is pretty hokie...
			string executingFolder = GetExecutingFolder();
			return Path.GetFullPath(Path.Combine(executingFolder, "..", "..", "..", "..", ".."));
		}
	}
}
