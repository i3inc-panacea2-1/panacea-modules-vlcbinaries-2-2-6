using Panacea.Modularity.VlcMediaPlayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modules.VlcBinaries_2_2_6
{
    public class VlcBinaries_2_2_6_Plugin : IVlcBinariesPlugin
    {
        public Task BeginInit()
        {
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            
        }

        public Task EndInit()
        {
            return Task.CompletedTask;
        }

        public string GetBinariesPath()
        {
            return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Vlc");
        }

        public string GetVersion() => "2.2.6";

        public Task Shutdown()
        {
            return Task.CompletedTask;
        }
    }
}
