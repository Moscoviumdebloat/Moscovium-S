using System;
using System.Collections.Generic;
using System.Text;

namespace Moscovium_S
{
    public static class SteamPathHelper
    {
        private const string CS2_CFG_RELATIVE = @"steamapps\common\Counter-Strike Global Offensive\game\csgo\cfg";

       
        public static List<string> FindCfgFolders()
        {
            var folders = new List<string>();

            
            var defaultPath = @"C:\Program Files (x86)\Steam\" + CS2_CFG_RELATIVE;
            if (Directory.Exists(defaultPath))
                folders.Add(defaultPath);

          
            foreach (var drive in DriveInfo.GetDrives().Where(d => d.IsReady))
            {
                try
                {
                    foreach (var steamDir in Directory.GetDirectories(drive.RootDirectory.FullName, "Steam", SearchOption.TopDirectoryOnly))
                    {
                        var cfgPath = Path.Combine(steamDir, CS2_CFG_RELATIVE);
                        if (Directory.Exists(cfgPath) && !folders.Contains(cfgPath))
                            folders.Add(cfgPath);
                    }
                }
                catch
                {
                    
                }
            }

            return folders;
        }
    }
}
