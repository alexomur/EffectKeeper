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
        public Dictionary<EffectType, bool> NewAllowedEffects { get; set; } = new Dictionary<EffectType, bool>()
        {
            [EffectType.Scp1853] = true,
            [EffectType.Scp207] = true,
            [EffectType.AntiScp207] = true,
            [EffectType.DamageReduction] = false,
            [EffectType.Bleeding] = false,
            [EffectType.Blinded] = false,
            [EffectType.Deafened] = false,
            [EffectType.MovementBoost] = false,
            [EffectType.Vitality] = false,
            [EffectType.Invigorated] = false,
            [EffectType.Invisible] = false,
            [EffectType.SeveredHands] = false,
            [EffectType.RainbowTaste] = false,
            [EffectType.SinkHole] = false,
            [EffectType.Stained] = false,
            [EffectType.Poisoned] = false,
            [EffectType.Hemorrhage] = false,
            [EffectType.Disabled] = false,
            [EffectType.Concussed] = false,
            [EffectType.CardiacArrest] = false,
            [EffectType.Burned] = false,
            [EffectType.Asphyxiated] = false,
            [EffectType.AmnesiaVision] = false,
            [EffectType.Flashed] = false,
            [EffectType.Exhausted] = false,
            [EffectType.InsufficientLighting] = false,
            [EffectType.Ensnared] = false,
            [EffectType.Corroding] = false,
            [EffectType.Scanned] = false
        };
    }
}