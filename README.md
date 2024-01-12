# UPDATED TO EXILED 8.6.0

# EffectKeeper
EXILED SCP:SL A plugin that saves the player's effects after he has escaped.
You can choose which effects will be saved after the escape in the config by adding `EffectType`s in `allowed_effects`.
# Config
```
EffectKeeper:
  is_enabled: true
  debug: false
  # Effects allowed to keep after respawning
  allowed_effects:
  - Scp1853
  - Scp207
  - AntiScp207
```
