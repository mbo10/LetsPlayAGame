namespace LetsPlayAGame
{
    public class GameComponent
    {
        public int Id { get; set; }
        public static int Instances = 0;
        public int timesCalled = 0;

        public GameComponent()
        {
            this.Id = ++Instances;
        }

        public virtual void Update(string eventTime)
        {
            timesCalled += 1;
            System.Console.WriteLine($"ID : {this.Id} Updated @ {eventTime}");
        }
    }

    public enum Direction
    {
        Left,
        Right,
        Up,
        Down
    }

}