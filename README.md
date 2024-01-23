# SpaceShips-Shaked
Part of week 3 assignment

This game is an action platformer. </br>
there are birds falling from the skies and you are requested to eliminate them in order to accumulate enough points (50 points) in order to advance to the next level! </br>
the game itself has 2 levels - normal birds' level and a boss. </br>
you can pick shields that are spawned to be invulnerable for one hit. </br>

Key Bindings - </br>
* Space - fire
* W, A - Movement.

You can try the game on [Itch.io-SpaceShips](https://shaggyx98.itch.io/spaceships)

## Changes

In my code i added few changes, i'll list them below:
* created random movement for enemies [EnemyRandomMover](https://github.com/HolyTrie/SpaceShips-Shaked/blob/main/Assets/Scripts/1-movers/RandomEnemyMover.cs)
* Player has to wait a few before attacking again [ClickSpawner](https://github.com/HolyTrie/SpaceShips-Shaked/blob/main/Assets/Scripts/2-spawners/ClickSpawner.cs)
* Spanwer can spawn more than one object at a time, in random way [TimedSpawnerRandom](https://github.com/HolyTrie/SpaceShips-Shaked/blob/main/Assets/Scripts/2-spawners/TimedSpawnerRandom.cs)
* I created a buff trigger, where it buffs the player when he picks the buffs [BuffTrigger](https://github.com/HolyTrie/SpaceShips-Shaked/blob/main/Assets/Scripts/3-collisions/BuffTrigger.cs)
* Added health to objects, which means after x hits the object will be destoryed [DestroyAfterHits](https://github.com/HolyTrie/SpaceShips-Shaked/blob/main/Assets/Scripts/3-collisions/DestroyAfterHits.cs)
* Altered the way score is given for diferrent enemies [ScoreAdder](https://github.com/HolyTrie/SpaceShips-Shaked/blob/main/Assets/Scripts/3-collisions/ScoreAdder.cs)
* Created boundaries for the player, where he reaches the horizontal edge he will pop up on the other side [TeleportPlayer](https://github.com/HolyTrie/SpaceShips-Shaked/blob/main/Assets/Scripts/3-collisions/TeleportPlayer.cs)
* Minor change to the sign, that will allow the player only to proceed to next level after x amount of points accumolated [GotoNextLevel](https://github.com/HolyTrie/SpaceShips-Shaked/blob/main/Assets/Scripts/4-levels/GotoNextLevel.cs)
