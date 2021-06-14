using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MinecraftServerHostLib.MinecraftTypes;
using System.Reflection;
using System.ComponentModel;

namespace MinecraftServerHostLib.Configs {
    public class ServerProperties {
        [ConfigName("spawn-protection")]
        public int? SpawnProtection { get; set; }

        [ConfigName("max-tick-time")]
        public int? MaxTickTime { get; set; }

        [ConfigName("query.port")]
        [Range(1, 65535, ErrorMessage = "Port must be between 1 - 65535")]
        public int? QueryPort { get; set; }

        [ConfigName("generator-settings")]
        public string? GeneratorSettings { get; set; }

        [ConfigName("sync-chunk-writes")]
        public bool? SyncChunkWrites { get; set; }

        [ConfigName("force-gamemode")]
        public bool? ForceGamemode { get; set; }

        [ConfigName("allow-nether")]
        public bool? AllowNether { get; set; }

        [ConfigName("enforce-whitelist")]
        public bool? EnforceWhitelist { get; set; }

        [ConfigName("gamemode")]
        public GamemodeType? Gamemode { get; set; }

        [ConfigName("broadcast-console-to-ops")]
        public bool? BroadcastConsoleToOps { get; set; }

        [ConfigName("enable-query")]
        public bool? EnableQuery { get; set; }

        [ConfigName("player-idle-timeout")]
        public int? PlayerIdleTimeout { get; set; }

        [ConfigName("text-filtering-config")]
        public string? TextFilteringConfig { get; set; }

        [ConfigName("difficulty")]
        public GameDifficulty? Difficulty { get; set; }

        [ConfigName("broadcast-rcon-to-ops")]
        public bool? BroadcastRconToOps { get; set; }

        [ConfigName("spawn-monsters")]
        public bool? SpawnMonsters { get; set; }

        [ConfigName("op-permission-level")]
        [Range(0, 4, ErrorMessage = "Op permission level must be between 0 - 4")]
        public int? OpPermissionLevel { get; set; }

        [ConfigName("pvp")]
        public bool? Pvp { get; set; }

        [ConfigName("entity-broadcast-range-percentage")]
        [Range(10, 1000, ErrorMessage = "Entity broadcast range percentage must be between 10 - 1000")]
        public int? EntityBroadcastRangePercentage { get; set; }

        [ConfigName("snooper-enabled")]
        public bool? SnooperEnabled { get; set; }

        [ConfigName("level-type")]
        public GameLevelType? LevelType { get; set; }

        [ConfigName("enable-status")]
        public bool? EnableStatus { get; set; }

        [ConfigName("resource-pack-prompt")]
        public string? ResourcePackPrompt { get; set; }

        [ConfigName("hardcore")]
        public bool? Hardcore { get; set; }

        [ConfigName("enable-command-block")]
        public bool? EnableCommandBlock { get; set; }

        [ConfigName("network-compression-threshold")]
        public int? NetworkCompressionThreshold { get; set; }

        [ConfigName("max-players")]
        public int? MaxPlayers { get; set; }

        [ConfigName("max-world-size")]
        [Range(1, 29999984, ErrorMessage = "World size must be between 1 - 29999984")]
        public int? MaxWorldSize { get; set; }

        [ConfigName("resource-pack-sha1")]
        public string? ResourcePackSha1 { get; set; }

        [ConfigName("function-permission-level")]
        [Range(1, 4, ErrorMessage = "Function permission level must be between 1 - 4")]
        public int? FunctionPermissionLevel { get; set; }

        [ConfigName("rcon.port")]
        [Range(1, 65535, ErrorMessage = "Port must be between 1 - 65535")]
        public int? RconPort { get; set; }

        [ConfigName("server-port")]
        [Range(1, 65535, ErrorMessage = "Port must be between 1 - 65535")]
        public int? ServerPort { get; set; }

        [ConfigName("server-ip")]
        [RegularExpression(@"\d+\.\d+\.\d+\.\d+", ErrorMessage = "Ip must be x.x.x.x")]
        public string? ServerIp { get; set; }

        [ConfigName("spawn-npcs")]
        public bool? SpawnNpcs { get; set; }

        [ConfigName("require-resource-pack")]
        public bool? RequireResourcePack { get; set; }

        [ConfigName("allow-flight")]
        public bool? AllowFlight { get; set; }

        [ConfigName("level-name")]
        [RegularExpression(@"^[a-zA-Z0-9]*(?! )$", ErrorMessage = "Your name must contain special characters")]
        public string? LevelName { get; set; }

        [ConfigName("view-distance")]
        [Range(3, 32, ErrorMessage = "View distance must be between 3 - 32")]
        public int? ViewDistance { get; set; }

        [ConfigName("resource-pack")]
        public string? ResourcePack { get; set; }

        [ConfigName("spawn-animals")]
        public bool? SpawnAnimals { get; set; }

        [ConfigName("white-list")]
        public bool? WhiteList { get; set; }

        [ConfigName("rcon.password")]
        public string? RconPassword { get; set; }

        [ConfigName("generate-structures")]
        public bool? GenerateStructures { get; set; }

        [ConfigName("online-mode")]
        public bool? OnlineMode { get; set; }

        [ConfigName("level-seed")]
        public string? LevelSeed { get; set; }

        [ConfigName("prevent-proxy-connections")]
        public bool? PreventProxyConnections { get; set; }

        [ConfigName("use-native-transport")]
        public bool? UseNativeTransport { get; set; }

        [ConfigName("enable-jmx-monitoring")]
        public bool? EnableJmxMonitoring { get; set; }

        [ConfigName("motd")]
        public string? Motd { get; set; }

        [ConfigName("rate-limit")]
        public int? RateLimit { get; set; }

        [ConfigName("enable-rcon")]
        public bool? EnableRcon { get; set; }

        public static string Serialize(ServerProperties serverProperties) {
            var stringBuilder = new StringBuilder();

            foreach (var property in typeof(ServerProperties).GetProperties()) {
                var propertyStringValue = property.GetValue(serverProperties) ?? string.Empty;
                var configName = property.GetCustomAttribute<ConfigNameAttribute>();

                if (configName is null) {
                    continue;
                }

                stringBuilder.AppendLine($"{configName.Name}={propertyStringValue}");
            }

            return stringBuilder.ToString();
        }

        public static ServerProperties Deserialize(string serverProperties) {
            var properties = serverProperties.Split(Environment.NewLine);

            var instance = new ServerProperties();
            foreach (var property in properties) {
                var configName = property.Split("=").FirstOrDefault();
                if (configName is null) {
                    continue;
                }

                var reflectedProperty = FindPropertyByConfigName(configName);
                if (reflectedProperty is null) {
                    continue;
                }

                var configStringValue = property.Split("=").LastOrDefault();
                if (string.IsNullOrEmpty(configStringValue)) {
                    continue;
                }

                var typeConverter = TypeDescriptor.GetConverter(reflectedProperty.PropertyType);
                var convertedType = typeConverter.ConvertFromString(configStringValue);

                reflectedProperty.SetValue(instance, convertedType);
            }
            return instance;
        }

        private static PropertyInfo? FindPropertyByConfigName(string configName) {
            var allProperties = typeof(ServerProperties).GetProperties();

            bool configNamePredicate(PropertyInfo propertyInfo) {
                var config = propertyInfo
                    .GetCustomAttribute<ConfigNameAttribute>();

                return config is not null
                    && config.Name == configName;
            }

            if (allProperties.Any(configNamePredicate)) {
                return allProperties.First(configNamePredicate);
            }

            return null;
        }
    }
}