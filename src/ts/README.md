Update for HnH

<p align="center">
<b>Digitalroot can be found in the Odin Plus Team Discord</b><br />
  <a href="https://discord.gg/BHbTumqG7U" target="_blank"><img src="https://digitalroot.net/img/odinplusdisc.png"></a>
</p>

Permission to fix and upload granted by Menthus.


# Heightmap Unlimited for Valheim

Vanilla Valheim restricts how high or low the terrain can be based on the starting elevation. This mod gets rid of those limits and allows players to dig down to water level or as high as they want, regardless of elevation. Comes with config for max/min height.

## GPORTAL Server Hosting
I've partnered with GPORTAL, a leading supplier of online game-hosting services around the globe. GPORTAL makes no compromises when it comes to your server's hardware, connection, routing and provides the best servers at an affordable cost!
[![GPORTAL Image](https://staticdelivery.nexusmods.com/images/3667/53098546-1618177653.png)](http://www.g-portal.com/?ref=Menthus15)

## Patreon
I spend countless hours every day working on, updating, and fixing mods for everyone to enjoy. While I will never ask for anyone to pay me to make a mod or add a feature, any support is greatly appreciated. >>[Check it out﻿](https://www.patreon.com/Menthus)<<, you might find benefits that catch your eye!

## Configuration
**You have 2 methods of configuration:**
1. Going to Valheim\BepInEx\config and opening Menthus.bepinex.plugins.HeightmapUnlimited.cfg.
2. Using the >>[BepInEx ConfigurationManager﻿]((https://github.com/BepInEx/BepInEx.ConfigurationManager/releases/tag/v16.1))<< plugin. Simply download it, put it in your Valheim\BepInEx\plugins folder, and press F1 when in-game.

**You have 3 configuration options:**

**[General]**  
**Is Server (defaults to false):** True means Heightmap Unlimited will behave as if it's installed on a dedicated server (this shouldn't be necessary otherwise).  
**Max Height (defaults to 200):** How high you can stack up relative to the heightmap's original position.  
**Min Height (defaults to 200):** How far you can dig down relative to the heightmap's original position.  

## Installation (manual):
This mod requires >>[BepInExPack](https://github.com/BepInEx/BepInEx.ConfigurationManager/releases/tag/v16.1)<< to work. Follow the BepInExPack installation instructions, then place the HeightmapUnlimited.dll (from the Heightmap Unlimited download) into the Valheim\BepInEx\plugins folder.

## Server Info  
Heightmap Unlimited forces players to have the same (unmodified) version installed in order to join your server. Otherwise they're given an "Incompatible Version" error.

Heightmap Unlimited syncs the server's config to connecting players without overwriting their config file (i.e., if a player connects to a server that has a different config, their config file won't change at all, but the depth and height values will reflect that of the server). This was done so players can have a "solo" config, but also join servers where the config is different.

## ChangeLog

### Heightmap Unlimited 1.3.0
- Updated for HnH

### Heightmap Unlimited 1.2.0
- Added "Is Server" config option.
- Added prefix to keys used for Heightmap Unlimited specific ZRoutedRpcs.
- Added server side support.
- Added version enforcement.
- Added server config syncing.
- General refactoring.Updated for Valheim version 0.150.3

### Heightmap Unlimited 1.1.1
- Updated for Valheim version 0.150.3

### Heightmap Unlimited 1.1.0
- Added config option MaxHeight(sets how high you can raise the ground relative to the point on the heightmap).
- Added config option MinHeight(sets how low you can dig relative to the point on the heightmap).
- General refactoring.

## Links

**GPORTAL**  
http://www.g-portal.com/?ref=Menthus15

**Patreon**  
https://www.patreon.com/Menthus

**GitHub**  
https://github.com/Menthus123

**Youtube**  
https://www.youtube.com/channel/UCfVYisJ8c6p37ol154rTHnw

**Twitter**  
https://twitter.com/OriginalMenthus