# Fix-The-Ship

Use WASD to move and space to shoot. Kill enemies and solve the puzzle to win.

itch.io : https://amitay2022.itch.io/fixtheshipsimple

# Scripts:

### [BoolTriger](https://github.com/Game-Project-Itay-Amit/Fix-The-Ship/blob/main/Assets/Scripts/BoolTrigger.cs) : 
Triggers an appropriate message in accordance with the player's answer on the quiz. This scripts recievs 3 fields: a bool that indicates wether or not the answer is correct, a TextMeshPro object for the message print and an array of objects to destroy once the quiz was answerd.

### [DestroyBullet](https://github.com/Game-Project-Itay-Amit/Fix-The-Ship/blob/main/Assets/Scripts/DestroyBullet.cs) : 
Destroys the bullet when it hits something.

### [DestroyOnKill](https://github.com/Game-Project-Itay-Amit/Fix-The-Ship/blob/main/Assets/Scripts/DestroyOnKill.cs) : 
Destroys the enemy character when its hit by a triggeringTag (bullet).

### [EndTrigger](https://github.com/Game-Project-Itay-Amit/Fix-The-Ship/blob/main/Assets/Scripts/EndTrigger.cs) : 
Loads the end message when touched by the player.

### [EnemyMover](https://github.com/Game-Project-Itay-Amit/Fix-The-Ship/blob/main/Assets/Scripts/EnemyMover.cs) : 
Moves an enemy character from start point to end point and back again.

### [Mover](https://github.com/Game-Project-Itay-Amit/Fix-The-Ship/blob/main/Assets/Scripts/Mover.cs) : 
Moves an object with the given velocity, in our case a bullet.

### [PlayerMover](https://github.com/Game-Project-Itay-Amit/Fix-The-Ship/blob/main/Assets/Scripts/PlayerMover.cs) : 
Moves the player according to the input from the user.

### [PositionFollower](https://github.com/Game-Project-Itay-Amit/Fix-The-Ship/blob/main/Assets/Scripts/PositionFollower.cs) : 
A game object that followes an other game object, in our case it follows the player. This is used as a parent object of the camera.

### [Shoot](https://github.com/Game-Project-Itay-Amit/Fix-The-Ship/blob/main/Assets/Scripts/Shoot.cs) : 
Spawns a new bullet if the given key was pressed, in our case the space bar.

### [TouchDetector](https://github.com/Game-Project-Itay-Amit/Fix-The-Ship/blob/main/Assets/Scripts/TouchDetector.cs) : 
Detects collisions between game objects.

### [isFixed](https://github.com/Game-Project-Itay-Amit/Fix-The-Ship/blob/main/Assets/Scripts/isFixed.cs) : 
Changes the text of a TextMeshPro according with the function selected.
