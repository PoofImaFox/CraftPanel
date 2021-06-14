using System;
using System.Diagnostics;
using System.IO;

namespace MinecraftServerHostLib {
    public class MinecraftServerProcess {
        private ProcessHost? _processHost;
        public MinecraftServerProcess() {

        }

        public void StartServer(int initialRam, int maxRam, string serverFolder) {
            if (_processHost is null) {
                _processHost = new ProcessHost(
                    new ProcessStartInfo("java", $"-Xmx{maxRam}G -Xms{initialRam}G -jar minecraftServer.jar nogui") {
                        WorkingDirectory = Path.GetFullPath(serverFolder)
                    }, true);
            }

            _processHost.Start();
        }

        public void StopServer() {
            _processHost?.Stop();
            _processHost = null;
        }

        public void RestartServer() {
            _processHost?.Restart();
        }
    }
}