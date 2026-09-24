namespace PhysicsObjects
{
    // A class that holds X and Y coordinates along with a name.
    public class GameObject
    {
        // Variables
        public string Name {get; private set;}
        public int X {get; private set;}
        public int Y {get; private set;}

        // Constructor
        public GameObject(string inputName, int inputX = 0, int inputY = 0)
        {
            Name = inputName;
            X = inputX;
            Y = inputY;
        }

        // Functions
        // Moves the object from its current position with the given coordinates.
        public void Move(int inputX, int inputY)
        {
            X += inputX;
            Y += inputY;
        }

        // Sets the position of the object to the given coordinates.
        public void SetPosition(int inputX, int inputY)
        {
            X = inputX;
            Y = inputY;
        }

        // Prints the position of the object.
        public void PrintPosition()
        {
            Console.WriteLine($"Object: {Name}'s position is X: {X}, Y: {Y}");
        }
    }

    // The collidingobject, a game object that can detect collisions with other colliders.
    public class CollidingObject : GameObject
    {
        // Variables
        public int Width {get; private set;}
        public int Height {get; private set;}

        // Constructor
        public CollidingObject(string inputName, int inputX = 0, int inputY = 0, int inputWidth = 1, int inputHeight = 1) : base(inputName, inputX, inputY)
        {
            Width = inputWidth;
            Height = inputHeight;
        }

        // Functions
        // Returns a boolean reperesenting if the object is colliding with the target object.
        public bool CollidesWith(CollidingObject target)
        {
            if ((X + Width >= target.X + target.Width && X - Width <= target.X - target.Width) && (Y + Height >= target.Y + target.Height && Y - Height <= target.Y - target.Height))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    // The player object, capable of picking up coins and earning score.
    public class Player : CollidingObject
    {
        // Variables
        public int Score {get; set;} = 0;

        // Constructor
        public Player(string inputName, int inputX = 0, int inputY = 0, int inputWidth = 1, int inputHeight = 1) : base(inputName, inputX, inputY, inputWidth, inputHeight){}
    }

    // A collectible object that the player can pickup to earn score.
    public class Collectible : CollidingObject
    {
        // Variables
        public int Points {get; private set;} = 1;

        // Constructor
        public Collectible(string inputName, int inputX = 0, int inputY = 0, int inputWidth = 1, int inputHeight = 1, int inputPoints = 1) : base(inputName, inputX, inputY, inputWidth, inputHeight)
        {
            Points = inputPoints;
        }
    }
}