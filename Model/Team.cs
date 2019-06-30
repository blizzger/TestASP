using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Team
    {
        public Team()
        {
            Players = new HashSet<Player>();
        }
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public int TeamRating { get; set; }
        public string Stadium { get; set; }
        public int StadiumCapacity { get; set; }
        public int Cups { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
