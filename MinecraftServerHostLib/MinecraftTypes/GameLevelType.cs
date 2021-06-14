using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftServerHostLib.MinecraftTypes {
    public enum GameLevelType {
        /// <summary>
        /// Standard world with hills, valleys, water, etc.
        /// </summary>
        Default,

        /// <summary>
        /// A flat world with no features, can be modified with generator-settings.
        /// </summary>
        Flat,

        /// <summary>
        /// Same as default but all biomes are larger.
        /// </summary>
        LargeBiomes,

        /// <summary>
        /// Same as default but world-generation height limit is increased.
        /// </summary>
        Amplified,

        /// <summary>
        /// Only for 1.15 or before. Same as default unless generator-settings is set.
        /// </summary>
        Buffet,

        /// <summary>
        /// Only for 1.15 or before. Same as default, but counted as a different world type.
        /// </summary>
        Default_1_1,

        /// <summary>
        /// Only for 1.15 or before. After 1.13, this value is no different than default, but in 1.12 and before, it could be used to create a completely custom world.
        /// </summary>
        Customized
    }
}
