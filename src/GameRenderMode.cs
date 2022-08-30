using System;

namespace Hardstuck.GuildWars2
{
    /// <summary>
    /// Render mode for the game (DirectX 9 or DirectX 11)
    /// </summary>
    public enum GameRenderMode
    {
        /// <summary>
        /// DirectX 9 - deprecated
        /// </summary>
        [Obsolete]
        DX9 = 9,

        /// <summary>
        /// DirectX 11
        /// </summary>
        DX11 = 11
    }
}
