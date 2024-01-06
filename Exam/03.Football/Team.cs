using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basketball
{
	public class Team
	{
		private List<Player> playears;

		public List<Player> Playears
		{
			get { return playears; }
			set { playears = value; }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int openPositions;

		public int OpenPositions
		{
			get { return openPositions; }
			set { openPositions = value; }
		}

		private char group;

		public char Group
		{
			get { return group; }
			set { group = value; }
		}



		public Team(string name, int openPositions,char group)
		{
			Name = name;
			OpenPositions = openPositions;
			Group = group;
			playears = new List<Player>();
		}


		public int Count { get { return playears.Count; } }

		public string AddPlayer(Player player)
		{
			if (player.Name == string.Empty || player.Position == string.Empty)
			{
				return "Invalid player's information.";
			}
			else if (openPositions==0)
			{
				return "There are no more open positions.";

			}
			if (player.Rating < 80)
			{
				return "Invalid player's rating.";

			}
			this.playears.Add(player);
            openPositions--;
            return $"Successfully added {player.Name} to the team. Remaining open positions: {openPositions}.";
			 
		}

        public bool RemovePlayer(string name)
		{
			var targetPlayer = playears.FirstOrDefault(x => x.Name == name);
			if (targetPlayer == null)
			{
				return false;
			}
			this.playears.Remove(targetPlayer);
			openPositions++;
			return true;
		}

        public int RemovePlayerByPosition(string position)
		{
            int countRemovedPlayers = 0;
            while (this.Playears.FirstOrDefault(x => x.Position == position) != null)
            {
                var targetPlayer = this.Playears.FirstOrDefault(x => x.Position == position);
                this.OpenPositions++;
                this.playears.Remove(targetPlayer);
                countRemovedPlayers++;
            }
            return countRemovedPlayers;
        }

        public Player RetirePlayer(string name)
		{
			var retiredPlayear = this.Playears.FirstOrDefault(x => x.Name == name);
			if (retiredPlayear == null)
			{
				return null;
			}
			retiredPlayear.Retired = true;
			return retiredPlayear;
		}

        public List<Player> AwardPlayers(int games) // първо иницеализираме дадения лист 
		{

			List<Player> awardPlayers = new List<Player>();
			foreach( var player in playears .Where (x=>x.Games >= games))
			{
				awardPlayers.Add(player);
			}
			return awardPlayers;

        }

		public string Report()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Active players competing for Team {this.Name} from Group {Group}:");

			foreach( var playear in playears.Where (x=>x.Retired != true))
			{
				sb.AppendLine(playear.ToString());
			}
			return sb.ToString().Trim();

        }





    }
}
