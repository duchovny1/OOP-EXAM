using System;
using System.Collections.Generic;
using System.Text;
using PlayersAndMonsters.Repositories.Contracts;

namespace PlayersAndMonsters.Models.Players
{
    public class Begginer : Player
    {
        private const int HEALTH = 50;

        public Begginer(ICardRepository cardRepository, string username)
            : base(cardRepository, username, HEALTH)
        {

        }
    }
}
