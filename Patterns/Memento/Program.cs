using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            PlayerSaves playerSaves = new PlayerSaves(player);
            player.Info();
            player.Attack();
            player.TakeDamage(10);
            player.Move(Direction.Up);
            player.Move(Direction.Up);
            player.Move(Direction.Up);
            player.Move(Direction.Up);
            playerSaves.SavePlayer();
            player.Info();
            player.Attack();
            player.TakeDamage(20);
            player.Move(Direction.Left);
            player.Move(Direction.Left);
            Console.WriteLine();
            player.Info();
            playerSaves.LoadPlayer();
            Console.WriteLine();
            player.Info();


        }
    }

    enum Direction
    {
        Up, Down, Left, Right
    }
    class Player
    {
        public Coord Coord { get; set; } = new Coord();
        public int HP { get; set; } = 100;
        public int Stamnia { get; set; } = 100;
        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    Coord.Y++;
                    break;
                case Direction.Down:
                    Coord.Y--;
                    break;
                case Direction.Left:
                    Coord.X--;
                    break;
                case Direction.Right:
                    Coord.X++;
                    break;
            }
        }
        public void TakeDamage(int damage)
        {
            HP -= damage;
        }
        public void Attack()
        {
            Stamnia -= 5;
        }

        public PlayerMemento Save()
        {
            return new PlayerMemento(Coord, HP, Stamnia);
        }

        public void Load(PlayerMemento memento)
        {
            Coord = memento.Coord;
            HP = memento.HP;
            Stamnia = memento.Stamnia;
        }
        public void Info()
        {
            Console.WriteLine($"Coords: {Coord.X} - {Coord.Y}");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"Stamnia: {Stamnia}");
        }
    }

    class PlayerMemento
    {
        public PlayerMemento(Coord coord, int hP, int stamnia)
        {
            Coord = coord;
            HP = hP;
            Stamnia = stamnia;
        }
        public Coord Coord { get; set; }
        public int HP { get; set; }
        public int Stamnia { get; set; }
    }
    
    class PlayerSaves
    {
        public Player Player { get; set; }
        public Stack<PlayerMemento> Saves { get; set; } = new Stack<PlayerMemento>();
        public PlayerSaves(Player player)
        {
            Player = player;
        }

        public void SavePlayer()
        {
            var memento = Player.Save();
            Saves.Push(memento);
        }
        public void LoadPlayer()
        {
            var memento = Saves.Pop();
            Player.Load(memento);
        }

    }

    public class Coord
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
    }
}
