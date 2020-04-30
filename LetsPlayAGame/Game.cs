using System;
using System.Collections.Generic;
using System.Timers;

namespace LetsPlayAGame
{
    public class Game
    {
        const int TICKS_1000MS = 1000;  
        Action _initialise;
        Action _terminate;
        readonly int _maxComponents;
        private int _componentCount { get; set; }
        private List<GameComponent> _components = new List<GameComponent>();
        private Timer timer = new Timer(TICKS_1000MS);

        public Game(int maxComponents)
        {
            _maxComponents = maxComponents;
        }

        public void SetInitialise(Action initialise)
        {
            _initialise = initialise;
        }

        public void SetTerminate(Action terminate)
        {
            _terminate = terminate;
        }

        public void Run()
        {
            _initialise();
            timer.AutoReset = true;
            timer.Start();
            _components.ForEach(c => process(c));
            _terminate();
        }

        public void Add(GameComponent gameComponent)
        {
            _components.Add(gameComponent);
        }

        private void process(GameComponent component)
        {
            timer.Elapsed += (sender, args) => {
                if (component.timesCalled < 5)
                {
                    component.Update(DateTime.Now.ToLongTimeString());
                }
                else
                {
                    return;
                }
            };
        }
    }
}
