using PlayersAndMonsters.Models.Cards.Contracts;
using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayersAndMonsters.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly List<IPlayer> players;

        public PlayerRepository()
        {
            players = new List<IPlayer>();
        }
        public int Count => players.Count;

        public IReadOnlyCollection<IPlayer> Players => this.players.AsReadOnly();

        public void Add(IPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentException("Card cannot be null");
            }
            if (Players.Any(x => x.Username == player.Username))
            {
                throw new ArgumentException($"Card {player.Username} already exists!");
            }

            this.players.Add(player);
        }

        public IPlayer Find(string name)
        {
            var card = Players.FirstOrDefault(x => x.Username == name);
            return card;
        }

        public bool Remove(IPlayer card)
        {
            if (card == null)
            {
                throw new ArgumentException($"Card canno be null");
            }

            return this.players.Remove(card);
        }
    }
}
