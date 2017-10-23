using System;

namespace Memento
{
    class Program
    {
        static void Play(Hero hero)
        {
            for (int i = 0; i < 5; i++)
            {
                hero.Run();
                hero.Shoot();
                hero.GetShoot();
                hero.Run();
            }
        }

        static void Main(string[] args)
        {
            Hero Rembo = new Hero();
            GameHistory GameHistory = new GameHistory();

            GameHistory.History.Push(Rembo.SaveState());

            Play(Rembo);

            Rembo.RestoreState(GameHistory.History.Pop());

            Play(Rembo);
            Console.ReadKey();
        }
    }
}
