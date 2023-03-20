
# TrinitySetStarterVisuals

This is a small tool build to change the visuals of the starter Pokemon in Pokémon Scarlet and Pokémon Violet.

It achives this by extracting the nessecary scene files from a RomFS Dump and creating a Mod Package compatible with the [TrinityModLoader](https://github.com/pkZukan/gftool)

## Requirements

To extract a direct RomFS Dump a copy of `oo2core_6_win64.dll` is needed.  
Due to Licensing this can not be provided here.

#### Game Files:
- RomFS Dump of  Pokémon Scarlet or Pokémon Violet __or__
- all the file that need to be changed in the correct folder structure

If any files can not be found the full path where they are searched for will be provided.

#### Important Notice:
In both cases the files need to be the original files from the game. Already modified files are not supported and wont be correctly changed.
## Scens that will be changed

#### common_0060_always
The first cuscene that plays when the Player leaves their house.
Here the Director lets out the 3 starters out of their Pokeballs.

Notable Complications:
- Ths Cutscene has a lot of Camera Moves that are fixed and expect the sizes of the original starters.
- because they are packed close together there is a fair amount of clipping

#### common_0060_main
This covers the free play part after the first Cutscene and before entering the next custscene.
#### d030_d030
This covers the Cinematic part of the Cutscene Playing at Nemonas house.

Notable Complications:
- This is a Cutscene with a lot of custom animations. expect unusual behaviour.

#### common_0070_always
This covers the second non scinematic part of the cuscene palyed at Nemonas house and the section while selecting your starter.

#### common_0088_always
This covers the cutscene after Selecting your starter.

Notable Complications:
- because your selected starter jumps on your shoulder there will be a fair amount of clipping if the selected model is too big.

#### common_0090_main
This covers the Cutscene playing before and after your first fight with Nemona on the beach showing the Director with the not starter taht is not chosen by either of the player and Nemona.
## Acknowledgements

 - [TrinityModLoader](https://github.com/pkZukan/gftool) for the easy to use ModLoader
 - [PokeDocs](https://github.com/pkZukan/PokeDocs) for a central repository of all know Flatbuffer schemas so far reverse engineered