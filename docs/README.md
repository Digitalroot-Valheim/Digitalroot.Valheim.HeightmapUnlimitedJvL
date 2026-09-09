# Heightmap Unlimited JvL

## Summary

Allows players to raise or lower terrain as much as they want! Comes with config so you can set the limits yourself.

## License
**GNU Affero General Public License v3.0**  
Closed-source license is available for commercial use.

## Details
Vanilla Valheim restricts how high or low the terrain can be based on the starting elevation. This mod gets rid of those limits and allows players to dig down to water level or as high as they want, regardless of elevation. Comes with config for max/min height.  
  
Permission to fix and upload granted by Menthus.

### Dependencies
- <a href="https://valheim.thunderstore.io/package/denikson/BepInExPack_Valheim/"  target="_blank">BepInExPack Valheim</a>
- <a href="https://github.com/Valheim-Modding/Jotunn" target="_blank">Jotunn (JVL)</a>

### Installation (manual)
1. Download the latest release archive (zip) file.
1. Extract the archive into &lt;Steam Location&gt;\steamapps\common\Valheim\BepInEx\plugins

### Configuration 

* **Max Height** (defaults to 200) - How high you can stack up relative to the heightmap's original position.
* **Min Height** (defaults to 200) - How far you can dig down relative to the heightmap's original position.

###### Add to server to enforce configs. 

### Upgrading from Menthus's Heightmap Unlimited

1. Remove **HeightmapUnlimited.dll** it could be in the following locations. 
   1. `<Steam Location>\steamapps\common\Valheim\BepInEx\plugins\HeightmapUnlimited.dll`
   1. `<Steam Location>\steamapps\common\Valheim\BepInEx\plugins\HeightmapUnlimited\HeightmapUnlimited.dll`
1. Open `<Steam Location>\steamapps\common\Valheim\BepInEx\config\Menthus.bepinex.plugins.HeightmapUnlimited.cfg`
1. Note the values for **Max Height** and **Min Height**.
1. Open `<Steam Location>\steamapps\common\Valheim\BepInEx\config\digitalroot.mods.heightmapunlimitedjvl.cfg`
1. Update the values for **Max Height** and **Min Height** to the same values you noted in step 3.
1. Remove `<Steam Location>\steamapps\common\Valheim\BepInEx\config\Menthus.bepinex.plugins.HeightmapUnlimited.cfg`

###### Upgrade Note
Follow the upgrade steps for both the client and server. 
Copying over the old mods values for the client is only needed for single player/local users. 
Users that connect to a server only need to remove the old mod and add the new one. 
The values from the server should push down to the clients when they connect.

### Issues/Questions/Bugs
- Use the repo issues tab above.

### Support Me @ https://www.buymeacoffee.com/digitalroot
<br />
<p align="center">
<b>Digitalroot can be found in the Valhalla Legends Discord</b><br /><br />
  <a href="https://discord.gg/SsMW3rm67u" target="_blank"><img src="https://digitalroot.net/img/vl/vl_logo_125x154.png"></a>
</p>
