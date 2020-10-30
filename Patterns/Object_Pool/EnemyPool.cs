using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Pool
{
    class EnemyPool
    {
        private Random rand = new Random();
        private Queue<Enemy> enemies = new Queue<Enemy>();
        public Enemy GetEnemy()
        {
            if (enemies.Count > 0)
            {
                return enemies.Dequeue();
            }
            return new Enemy() { Name =  Convert.ToChar(rand.Next(65, 85)), X = rand.Next(0,10), Y = rand.Next(0,10) };
        }
        public void ReturnEnemy(Enemy enemy)
        {
            enemies.Enqueue(enemy);
        }
    }
}
