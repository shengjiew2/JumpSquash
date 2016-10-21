Group Details:
Bethany Drake (drakeb) 758774
Shengjie Wang (shengjiew2) 763270

In Loving Memory of Bunny.
RIP <3

What the application does:
JumpSquash is a pass and play game based on the board-game "Trouble". 

How to use it:
In the menu screen, click/touch "instuctions" to see how to play, "options" to turn sound on/off, and "new game" to play. 
After clicking new game, the game will display a prompt saying whose turn it is. 
That player should press "okay", then shake the device or touch the screen to roll the dice. 
Then, they should select a moveble bunny (highlighted by sparkles).
Then, it is the next players turn.
The first player to get all of the bunnies around the board and safely back to the home row is the winner, and a congratulations screen will appear.
From the congratulations screen, users can return to the main menu and repeat.

Additional enforce rules:
If a player has no moveable bunnies, it is the next player's turn. 
A bunny can only be moved from the homerow if the player has rolled a five or a six.
A bunny cannot be moved if it will land exactly on another bunny on the same team. 
If a bunny lands exactly on a bunny from the other team, that bunny will be sent back to the start. 

Objects:
Bunnies:
Bunnies are are a capsule of high mass representing the body. The head is a lighter sphere attatched to the body by a spring.
The ears, lighter still, are attatched to the head by hinge joints.
This all uses unity physics. 
When jumping, bunnies move at a constant horizontal speed. They calculate how high they need to jump for their current target.
At the same time, they calculate how long it should take to get there. (All using standard projectile motion formulas).
When enough time passed that they should have reached their target, they calculate and execute the next bounce. 

Die:
The die is a cube. When the dice is rolled, upwards velocity is added, as well as a random horizontal velocity and torque.
When the die's velocity is below a threshold for a set amount of time, it has finished rolling. 
When it has finished rolling, it casts a ray upwards (in world space). This ray is used to return the value of the upward face.
There is an invisible container that stops the die going outside the board.   
This uses unity physics.


Effects:
Bunnies (normal):
Basic Phong shader, adapted from lab05, with high specularity to resemble plastic units from the original version. 
Bunnies (sparkly): Turns random fragments white in the fragment shader, using the relative position of a point light as a seed. 
This overlays the Basic Phong shader. Uses Micheal Pohereski's random number generator. 
Bunnies (grey): Basic phong shader which rounds values in the fragment shader.
This is used to create a flat effect for bunnies that are no longer in play. 
Die:
Bump map, created in photoshop, used to create dimples in the numbers on the dice. Uses standard shader.
Stones:
Bump map imported from Unity Asset store. Uses standard shader.
Ground: random image from google. Probably not copyrighted, right? Uses standard shader.
Lighting: position of light changes slowly over time, simulating sun movement in the artic day. 
Menu:
The background for the menu is taken from http://bizhi.sogou.com/detail/info/27954/48539.
The background is overlaid with partical effects using Unity Partical systems with Emission, shape, and renderer applied, and customized parameters.
This is overlaid with semi-transparent Unity UI buttons and panels. 
These are animated with Unity animator.  
Size is independant of screen width but varies with height to maintain the design. 
Congratulations screen:
Camera moves triumphantly around the winning bunny. The light fades in and out, and a different partical effect (also using Unity Partical System)
showers the bunny in a cascade of glory. 


Sourced assets:
Stone texture bump map imported from Unity Asset store.
Grassy image from google. 
Menu background from http://bizhi.sogou.com/detail/info/27954/48539.
Randomness code from Micheal Pohereski.
Music from http://www.mtv123.com/zhuanji/15111.shtml

