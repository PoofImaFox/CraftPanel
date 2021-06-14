using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftServerHostLib.Configs {

    [AttributeUsage(AttributeTargets.Property)]
    public class ConfigNameAttribute : Attribute {
        public string Name { get; init; }
        public ConfigNameAttribute(string name) {
            Name = name;
        }
    }
}
