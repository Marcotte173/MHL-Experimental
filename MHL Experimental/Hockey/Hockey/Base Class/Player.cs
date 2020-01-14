public class Player
{
        protected string name;
        protected int speed;
        protected int handling;
        protected int passing;
        protected int shooting;
        protected int checking;
        protected int balance;
        protected int offAware;
        protected int defAware;
        protected int block;
        protected double coefficient;
        protected double price;
        protected string position;
        protected int glove;
        protected int stick;
        protected int angles;
        protected int agility;
        protected int butterfly;


        public Player() { }
        public virtual double Overall { get { return 0; } }
        public virtual double Price { get { return 0; } }
        public string Name { get { return name; } }
        public int Speed { get { return speed; } }
        public int Handling { get { return handling; } }
        public int Passing { get { return passing; } }
        public int Shooting { get { return shooting; } }
        public int Checking { get { return checking; } }
        public int Balance { get { return balance; } }
        public int Block { get { return block; } }
        public int OffAware { get { return offAware; } }
        public int DefAware { get { return defAware; } }
        public string Position { get { return position; } }
        public int Glove { get { return glove; } }
        public int Stick { get { return stick; } }
        public int Angles { get { return angles; } }
        public int Agility { get { return agility; } }
        public int Butterfly { get { return butterfly; } }

}