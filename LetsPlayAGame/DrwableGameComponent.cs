namespace LetsPlayAGame
{
    public class DrwableGameComponent : GameComponent
    {
        private int _x;
        private int _y;
        public const int SCREEN_HEIGHT = 20;
        public const int SCREEN_WIDTH = 80;

        public Direction direction { get; private set; }
        public DrwableGameComponent(int x = 0, int y = 0): base()
        {
            _x = x;
            _y = y;
            direction = Direction.Right;
        }
        public override void Update(string eventTime)
        {
            base.Update(eventTime);
            ChangeDirection();
            Draw();
        }

        private void Draw()
        {
            System.Console.WriteLine($"{direction} : X:{_x}  Y:{_y}");
        }

        private void ChangeDirection()
        {
            switch (direction)
            {
                case Direction.Left:
                    _x -= 1;
                    direction = Direction.Right;
                    break;
                case Direction.Right:
                    _x += 1;
                    direction = Direction.Down;
                    break;
                case Direction.Up:
                    _y -= 1;
                    direction = Direction.Left;
                    break;
                case Direction.Down:
                    _y += 1;
                    direction = Direction.Up;
                    break;
                default:
                    break;
            }
        }
    }
}