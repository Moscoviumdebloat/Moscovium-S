using System;
using System.Collections.Generic;
using System.Text;

namespace Moscovium_S
{
    public class ThemeService
    {

        public event Action OnThemeChanged;

        private bool _isLightMode = Properties.Settings.Default.LightMode;
        public bool IsLightMode
        {
            get => _isLightMode;
            set
            {
                if (_isLightMode != value)
                {
                    _isLightMode = value;
                    OnThemeChanged?.Invoke();
                    Properties.Settings.Default.LightMode = value;
                    Properties.Settings.Default.Save();

                }
            }
        }
    }
}
