using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MinecraftServerHostLib {
    public class ProcessHost {
        public Queue<(DateTime createdTime, string outputData)> OutputDataQueue { get; }
            = new Queue<(DateTime createdTime, string outputData)>();

        public List<Regex> IgnoreRegex { get; } = new List<Regex>();

        private Process? _hostedProcess;
        private readonly ProcessStartInfo _processStartInfo;
        private readonly bool _restartIfcrash;

        private bool _watchForCrash = false;

        public ProcessHost(ProcessStartInfo processStartInfo, bool restartIfcrash) {
            _restartIfcrash = restartIfcrash;

            _processStartInfo = processStartInfo;

            _processStartInfo.RedirectStandardInput = true;
            _processStartInfo.RedirectStandardOutput = true;
            _processStartInfo.RedirectStandardError = true;
        }

        public bool Restart() {
            if (!Stop()) {
                return false;
            }

            if (!Start()) {
                return false;
            }

            return true;
        }

        public bool Stop() {
            if (_hostedProcess is null) {
                return false;
            }

            _watchForCrash = true;
            _hostedProcess.Kill();
            _hostedProcess.Dispose();
            return true;
        }

        public bool Start() {
            _hostedProcess = Process.Start(_processStartInfo);
            if (_hostedProcess is null) {
                return false;
            }

            _watchForCrash = true;
            _hostedProcess.EnableRaisingEvents = true;

            _hostedProcess.Exited += Exited;
            _hostedProcess.OutputDataReceived += OutputDataReceived;

            return true;
        }

        public void WriteInput(string input) {
            if (_hostedProcess is null) {
                return;
            }

            _hostedProcess.StandardInput.WriteLine(input);
        }

        private void OutputDataReceived(object sender, DataReceivedEventArgs e) {
            var receivedData = e.Data ?? string.Empty;

            if (IgnoreRegex.Any(i => i.IsMatch(receivedData))) {
                return;
            }

            OutputDataQueue.Enqueue((DateTime.Now, receivedData));
        }

        private void Exited(object? sender, EventArgs e) {
            if (_watchForCrash && _restartIfcrash) {
                Start();
            }
        }
    }
}