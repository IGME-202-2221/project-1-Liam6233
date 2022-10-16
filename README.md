# Project 1 Shmup. 

[Markdown Cheatsheet](https://github.com/adam-p/markdown-here/wiki/Markdown-Here-Cheatsheet)

### Student Info

-   Name: Liam Curley
-   Section: 06

## Game Design

-   Camera Orientation: Camera has a side view.
-   Camera Movement: The camera itself does not move, however the objects in the game move giving the illusion that the camera is moving from left to right
-   Player Health: The player's health is is a life bar where the player can take 10 hits before a game over, if the player has lost health, hitting 16 shots on enemies restores 1 health.
-   End Condition: The goal of the game is to survive for as long as possible, therefore the end condition is when the player's health is at 0
-   Scoring: player gains 5 points when a bullet hits an enemy, and 1 point gained for every second the player is alive.

### Game Description

Title: Last stand
Description: You are the last ship in a fleet that was destroyed in a recent space battle between Humanity and an alien menace. Escape is impossible so you decide to go down fighting. Take on waves of enemies and survive for as long as possible to show those aliens why you shouldn't mess with humanity.

### Controls

-   Movement
    -   Up: W or Up Arrow
    -   Down: S or Down Arrow
    -   Left: A or Left Arrow
    -   Right: D or Right Arrow
-   Fire/Menu Navigation: Left Mouse Button
-   Screen Bounds Interaction: Warp around top and bottom of screen, left and right edges are hard bounds

## You Additions

- Using Point to Shape Collision for player bullets, where bullets move so fast that it behaves like hitscan
- To compensate for player having a hitscan weapon, enemies with have unique movement patterns and will take multiple hits to kill
- Game has a main Menu with instructions and a button to go to the gameplay
- Game has a game over screen that lets you play again or go to the main menu

## Enemies
- Green Bean: small enemy that takes 2 hits before being destroyed
- Attacker: Box like ship that takes 4 hits to destroy and fires a bullet every 1.8 second
- Tank: larger enemy ship that takes 6 hits to destroy and fires a bullet every 1.3 seconds

Movement Patterns: 
1. straight line: this one is unique since every enemy moving in straight line will move at a different speed within a range that is randomly selected
2. Sine Wave: moves in a wavey pattern
3. moving diagonal down and right forever, wraps around screen until hitting left edge and dying
4. Moving diagonal Up and right forever, also wraps around screen to keep it interesting.

## Sources

1. Spaceship Model for player I got from OpenGameArt.org, 
    https://opengameart.org/content/spaceship-360

2. Sprites for projectile and enemy ships
    https://opengameart.org/content/enemy-spaceship-2d-sprites-pixel-art

3. when placing buttons, in main menu scene in unity, button is below camera meaning you cannot get to gameplay scene from mainmenu scene ONLY bug in Unity Editor, webgl build work as expected. Bug only present because of how buttons are placed in webgl build is different than in unity editor

## Known Issues

_List any errors, lack of error checking, or specific information that I need to know to run your program_

- *FIXED* Enemy List in Collision Manager will occasionally get Index Out of bounds range error. However I don't know how to trigger it and it does not crash the program. it is also infrequent so I would just ignore them. I got 2 after 5 minutes of playing.

- Small bug where due to how collision works. when shooting enemies the bullets sometimes hit enemys behind other enemies first due to their position in the enemy list where enemies closer to index 0 get hit first even if they are behind another enemy. this could be solved by sorting list via x position but I don't have time to do that. 

### Requirements not completed


