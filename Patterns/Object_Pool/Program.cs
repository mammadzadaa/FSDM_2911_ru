using System;

namespace Object_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            var pool = new EnemyPool();
            var enemy = pool.GetEnemy();
            var enemy1 = pool.GetEnemy();
            var enemy2 = pool.GetEnemy();
            ShowEnemyPosition(enemy);
            ShowEnemyPosition(enemy1);
            ShowEnemyPosition(enemy2);
            Console.ReadKey();
            pool.ReturnEnemy(enemy1);
            pool.ReturnEnemy(enemy2);
            Console.Clear();
            var enemy3 = pool.GetEnemy();
            var enemy4 = pool.GetEnemy();
            ShowEnemyPosition(enemy3);
            ShowEnemyPosition(enemy4);
            Console.ReadKey();


        }
        public static void ShowEnemyPosition(Enemy enemy)
        {
            Console.SetCursorPosition(enemy.X, enemy.Y);
            Console.WriteLine(enemy.Name);
        }
    }
}
