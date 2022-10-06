# Project PROJECT_NAME

[Markdown Cheatsheet](https://github.com/adam-p/markdown-here/wiki/Markdown-Here-Cheatsheet)

### Student Info

-   Name: Liam Curley
-   Section: 06

## Game Design

-   Camera Orientation: Camera has a side view.
-   Camera Movement: The camera itself does not move, however the objects in the game move giving the illusion that the camera is moving from left to right
-   Player Health: The player's health is is a life bar where the player can take 5 hits before a game over, if the player has lost health, scoring 150 points restores 1 health.
-   End Condition: The goal of the game is to survive for as long as possible, therefore the end condition is when the player's health is at 0
-   Scoring: player gains 20 points by destroying enemies, and 1 point gained for every second the player is alive.

### Game Description

Title: Last stand
Description: You are the last ship in a fleet that was destroyed in a recent space battle between Humanity and an alien menace. Escape is impossible so you decide to go down fighting. Take on waves of enemies and survive for as long as possible to show those aliens why you shouldn't mess with humanity.

### Controls

-   Movement
    -   Up: W or Up Arrow
    -   Down: S or Down Arrow
    -   Left: A or Left Arrow
    -   Right: D or Right Arrow
-   Fire/Menu Navigation: Spacebar or Left Mouse Button
-   Pause: Tab

## You Additions

- Screen Bound Interactions: Top and Bottom of the screen wrap around like in Exercise 4, but left and right edges are hard borders that stop the player from going beyond them
- Pause Menu so that player can take break during gameplay.
- Using Point to Shape Collision for player bullets, where bullets move so fast that it behaves like hitscan
- to compensate for player having a hitscan weapon, enemies with have unique movement patterns and will take multiple hits to kill
- Player can shoot as fast as they can press spacebar or Left Mouse Button. No automatic fire
- Player can move vertically faster than they can move horizontally

## Sources

-   _List all project sources here –models, textures, sound clips, assets, etc._
1. Spaceship Model for player I got from OpenGameArt.org, 
    https://opengameart.org/content/spaceship-360

2. Sprite for projectile and enemy ships
    https://opengameart.org/content/enemy-spaceship-2d-sprites-pixel-art
-   _If an asset is from the Unity store, include a link to the page and the author’s name_

## Known Issues

_List any errors, lack of error checking, or specific information that I need to know to run your program_

### Requirements not completed

_If you did not complete a project requirement, notate that here_

