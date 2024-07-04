using System.Collections.Generic;

namespace EvertonProject.Models
{
    public class TeamInfo
    {
        public string TeamName { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
        public List<Player> Players { get; set; }
    }

    public class Player
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Number { get; set; }
    }
}
