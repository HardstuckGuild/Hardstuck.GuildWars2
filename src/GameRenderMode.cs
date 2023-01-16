using System;

namespace Hardstuck.GuildWars2
{
    /// <summary>
    /// Render mode for the game (DirectX 9 or DirectX 11)
    /// </summary>
    [Obsolete("DirectX11 will be the only render mode available in the game starting April 18th 2023, rendering this enum unnecessary.")]
    public enum GameRenderMode
    {
        /// <summary>
        /// DirectX 9 - deprecated
        /// </summary>
        [Obsolete("DirectX9 is deprecated by the game and will be removed on April 18th 2023.")]
        DX9 = 9,

        /// <summary>
        /// DirectX 11
        /// </summary>
        [Obsolete("DirectX11 will be the only render mode available in the game starting April 18th 2023, rendering this enum unnecessary.")]
        DX11 = 11,
    }
}
