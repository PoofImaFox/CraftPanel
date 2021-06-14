using System;

using MinecraftServerHostLib.Configs;
using MinecraftServerHostLib.MinecraftTypes;

using Xunit;

namespace MinecraftServerHostLib.Tests {
    public class ConfigTests {

        [Fact]
        public void TestServerProperties() {
            var properties = new ServerProperties() {
                Motd = "Test data type conversion.",
                AllowFlight = true,
                Difficulty = GameDifficulty.Hard,
                Gamemode = GamemodeType.Creative,
                ForceGamemode = false,
                LevelType = GameLevelType.Flat,
                SpawnProtection = 16,
                ServerIp = "127.0.0.1"
            };

            var serialized = ServerProperties.Serialize(properties);
            var deserialized = ServerProperties.Deserialize(serialized);

            Assert.Equal(properties.Motd, deserialized.Motd);
            Assert.Equal(properties.AllowFlight, deserialized.AllowFlight);
            Assert.Equal(properties.Difficulty, deserialized.Difficulty);
            Assert.Equal(properties.Gamemode, deserialized.Gamemode);
            Assert.Equal(properties.ForceGamemode, deserialized.ForceGamemode);
            Assert.Equal(properties.LevelType, deserialized.LevelType);
            Assert.Equal(properties.SpawnProtection, deserialized.SpawnProtection);
            Assert.Equal(properties.ServerIp, deserialized.ServerIp);
        }
    }
}
