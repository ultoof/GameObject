using PhysicsObjects;

// Variables
CollidingObject testObject1 = new CollidingObject("TestObject1",1,2,10,3);
CollidingObject testObject2 = new CollidingObject("TestObject2",-8,0,1,1);
Player player = new Player("Player");
Collectible collectible1 = new Collectible("Coin1",0,0,1,1,1);
Collectible collectible2 = new Collectible("Coin2",2,2,1,1,5);

// Runtime
Console.Clear();

// Position & Collider Test
// Tests collisions aswell as the SetPosition() function, returns true for a valid collision and false for no collision
testObject1.PrintPosition();
Console.WriteLine(testObject1.CollidesWith(testObject2));
testObject1.SetPosition(3,0);
testObject1.PrintPosition();
Console.WriteLine(testObject1.CollidesWith(testObject2));

// Player Test
// Test the Move() function aswell as picking up collectibles and gaining score with the Player and Collectible classes. The first
// Coin gives 1 point and the second gives 6
if (player.CollidesWith(collectible1))
{
    Console.WriteLine($"Player picked up a coin and gained {collectible1.Points} score");
    player.Score += collectible1.Points;
}

Console.WriteLine($"Player has {player.Score} score");
player.Move(2,2);

if (player.CollidesWith(collectible2))
{
    Console.WriteLine($"Player picked up a coin and gained {collectible2.Points} score");
    player.Score += collectible2.Points;
}

Console.WriteLine($"Player has {player.Score} score");