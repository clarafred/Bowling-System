namespace BowlingSystem
{
    public class Player
    {
        public string Name { get; }
        public Round Round { get; set; }
        public Player(string name)
        {
            Name = name;
            Round = new Round();
        }
    }
}