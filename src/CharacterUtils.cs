﻿using System.Linq;

namespace Hardstuck.GuildWars2
{
    /// <summary>
    /// Provides sets of utility methods for handling character names.
    /// </summary>
    public static class CharacterUtils
    {
        /// <summary>
        /// Converts the string to a properly spaced character name.
        /// </summary>
        /// <param name="characterName">unconverted character name</param>
        /// <returns>converted character name</returns>
        public static string ToCharacterName(this string characterName) => ConvertToCharacterName(characterName);

        /// <summary>
        /// Converts the string to a properly spaced character name.
        /// </summary>
        /// <param name="characterName">unconverted character name</param>
        /// <returns>converted character name</returns>
        public static string ConvertToCharacterName(string characterName) => characterName.Split(' ').Where(x => x.Length > 0).Select(x => x.ToLower()).Select(x => x[0].ToString().ToUpper() + x.Substring(1)).Aggregate((x, y) => $"{x} {y}");
    }
}
