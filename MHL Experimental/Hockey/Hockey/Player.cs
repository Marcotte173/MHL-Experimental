using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hockey
{
    public class Player
    {
        string name;
        int speed;
        int handling;
        int passing;
        int shooting;
        int checking;
        int balance;
        int offAware;
        int defAware;
        int block;
        double coeffiecient;
        double price;

        public Player(string name, int speed, int handling, int passing, int shooting, int checking, int balance, int offAware, int defAware, int block, double coeffiecient)
        {
            this.name = name;
            this.speed = speed;
            this.handling = handling;
            this.passing = passing;
            this.shooting = shooting;
            this.checking = checking;
            this.balance = balance;
            this.offAware = offAware;
            this.defAware = defAware;
            this.block = block;
            this.coeffiecient = coeffiecient;
        }
        public double Overall { get { return (speed * 2 + handling + passing * 2 + shooting * 2 + checking + balance) / 9; } }
        public double Price { get { return ((speed * 2 + handling + passing * 2 + shooting * 2 + checking + balance) / 9) * 300 * coeffiecient; } }
        public string Name { get { return name; } }
        public int Speed { get { return speed; } }
        public int Handling { get { return handling; } }
        public int Passing { get { return passing; } }
        public int Shooting { get { return shooting; } }
        public int Checking { get { return checking; } }
        public int Balance { get { return balance; } }        
    }
}