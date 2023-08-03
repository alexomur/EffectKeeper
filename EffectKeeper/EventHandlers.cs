using System.Collections.Generic;
using Exiled.API.Extensions;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using Player = Exiled.API.Features.Player;

using MEC;


namespace EffectKeeper
{
    public class EventHandlers
    {
        private bool IsPlaying(Player player)
        {
            if (player.Role == RoleTypeId.None || player.Role == RoleTypeId.Overwatch ||
                player.Role == RoleTypeId.Spectator)
            {
                return false;
            }

            if (!player.IsConnected || !player.IsVerified)
            {
                return false;
            }

            return true;
        }
        
        /*
         Here, after waiting a couple of seconds,
         effects will be given to the player with the new role.
         */
        private IEnumerator<float> CoroutineEffect(Player player, List<Effect> effects)
        {
            yield return Timing.WaitForSeconds(2);

            player.EnableEffects(effects);
        }
        
        /*
        Not allowed effects will be removed here. 
        After that, the information will be transferred to the coroutine, 
        which will issue effects after the player respawns.
        */
        public void OnEscaping(EscapingEventArgs ev)
        {
            if (!IsPlaying(ev.Player)) return;
            
            var effects = new List<Effect>();
            foreach (var effect in ev.Player.ActiveEffects)
            {
                if (!Plugin.Instance.Config.AllowedEffects.Contains(effect.GetEffectType()))
                { 
                    continue;
                }
                effects.Add(new Effect(effect.GetEffectType(), effect.Duration));
            }



            Timing.RunCoroutine(CoroutineEffect(ev.Player, effects));
        }
        
    }
}