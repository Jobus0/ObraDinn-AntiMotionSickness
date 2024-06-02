# Obra Dinn Anti-Motion Sickness

A mod for Return of the Obra Dinn that disables motion sickness-inducing effects and allows modifying the FOV.

### Specifically:
- Adds a FOV option which defaults to 70 (up from 58).
- Disables the swaying of the ship.
- Disables the fringe distortion post-process effect (wavy edges of the screen) during memories.
- Disables the blurring of the edges of the screen.
- Disables the constant head bobbing when the player is walking.

With these changes, I went from feeling sick after just 15 minutes, to being able to play for 6 hours straight with no problem.

I have played through the whole game with this mod.

## Installation
1. Download the latest release of [BepInEx](https://github.com/BepInEx/BepInEx/releases) (must use **x86** version).
2. Extract the .zip's contents into your Obra Dinn directory.
3. Create a new directory called Plugins inside the BepInEx directory.
4. [Download](https://github.com/Jobus0/ObraDinnAntiMotionSickness/releases/latest) this mod and extract its contents into the Plugins directory.
    - The final path should look like: `Obra Dinn\BepInEx\Plugins\AntiMotionSickness.dll`

## Config
All the features of this mod can be individually toggled (or tweaked for FOV).

To do so, first launch and exit the game once the mod has been installed. A .cfg file will have been generated in the BepInEx\config directory. Open that file (ObraDinnAntiMotionSickness.cfg) with any text editor and modify the values as you like.

For FOV, note that the engine uses *vertical* FOV, so the default values are larger than they might seem.

Any changes to the .cfg file while the game is running will only take effect when you have restarted the game.