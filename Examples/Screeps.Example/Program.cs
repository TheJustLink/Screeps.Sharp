using System;

using Bridge;

using Screeps.World;

namespace Screeps.Example
{
    public class Program
    {
        // Bridge.NET C# 7.3 support
        
        private static int _elapsedTicks;
        private static dynamic _test;

        public static void Main()
        {
            Console.WriteLine("Initialization");
            _test = Script.Call<dynamic>("require", "test");
            Game.Loop = Loop;
        }

        private static void Loop()
        {
            _elapsedTicks++;

            var game = Script.Get<dynamic>("Game");

            Console.WriteLine($"[CSharpUpdate] tick : {Game.Time}, elapsed ticks : {_elapsedTicks}");
            Console.WriteLine(_test.Text);
            Console.WriteLine($"[CSharpUpdate] tick : {game.time} (dynamic)");
            Console.WriteLine($"[CSharpUpdate] creeps : {game.cpu.getUsed()}/{game.cpu.limit}, bucket : {game.cpu.bucket}");
            Console.WriteLine($"Current Time : {DateTime.Now}");
        }
    }
}