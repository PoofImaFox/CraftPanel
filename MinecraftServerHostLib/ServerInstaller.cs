using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MinecraftServerHostLib {
    public static class ServerInstaller {
        private const string LATEST_RELEASE_PAGE = "https://www.minecraft.net/en-us/download/server";
        private const string MINECRAFT_FOLDER = "MinecraftServer";

        private static readonly Regex _matchServerDownload = new Regex(@"https:\/\/launcher\.mojang\.com.+server\.jar");
        public static void ResetDirectoryStructure() {
            if (Directory.Exists(MINECRAFT_FOLDER)) {
                Directory.Delete(MINECRAFT_FOLDER, true);
            }

            Directory.CreateDirectory(MINECRAFT_FOLDER);
        }

        public static async Task<string> GetLatestDownloadUrl() {
            var client = new HttpClient();
            var httpResponse = await client.GetAsync(LATEST_RELEASE_PAGE);
            if (!httpResponse.IsSuccessStatusCode) {
                return string.Empty;
            }

            var responseBody = await httpResponse.Content.ReadAsStringAsync();
            var regexMatch = _matchServerDownload.Match(responseBody);

            if (!regexMatch.Success) {
                return string.Empty;
            }

            return regexMatch.Value;
        }
    }
}