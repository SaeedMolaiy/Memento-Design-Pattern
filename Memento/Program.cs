using System;
using Memento.Models;

namespace Memento
{
    internal class Program
    {
        static void Main()
        {
            var marioGame = new MarioGame(new History())
            {
                CurrentLevel = Level.Level1
            };
            marioGame.Save();

            marioGame.CurrentLevel = Level.Level2;
            marioGame.Save();

            marioGame.CurrentLevel = Level.Level3;
            //we didn't save this value so if we call restore method
            //it should change CurrentLevel value from Level3 to Level2 
            marioGame.Restore();
            Console.WriteLine("Current Level Is : " + marioGame.CurrentLevel);
        }
    }
}
