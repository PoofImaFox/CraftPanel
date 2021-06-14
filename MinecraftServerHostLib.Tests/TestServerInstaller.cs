using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace MinecraftServerHostLib.Tests {
    public class TestServerInstaller {
        [Fact]
        public async Task TestGetLatestDownloadUrl() {
            var installUrl = await ServerInstaller.GetLatestDownloadUrl();
            Assert.StartsWith("http", installUrl);
        }
    }
}