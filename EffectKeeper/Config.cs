using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Enums;
using Exiled.API.Interfaces;

namespace EffectKeeper
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public bool Debug { get; set; } = false;

        [Description("Effects allowed to keep after respawning")]
        public List<EffectType> AllowedEffects { get; set; } = new List<EffectType>()
        {
            EffectType.Scp207,
            EffectType.Scp1853,
            EffectType.AntiScp207
        };
    }
}