namespace PlayersAndMonsters.Core
{
    using System;

    using Contracts;
    using PlayersAndMonsters.Models.Cards;
    using PlayersAndMonsters.Models.Cards.Contracts;
    using PlayersAndMonsters.Models.Players;
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories;
    using PlayersAndMonsters.Repositories.Contracts;

    public class ManagerController : IManagerController
    {
        IPlayerRepository players;
        ICardRepository cardRepository;

        public ManagerController()
        {
            players = new PlayerRepository();
            cardRepository = new CardRepository();
        }

        public string AddPlayer(string type, string username)
        {

            IPlayer player = null;

            if (type == "Begginner")
            {

                player = new Begginer(cardRepository, username);
            }
            else if (type == "Advanced")
            {

                player = new Advanced(cardRepository, username);

            }

            this.players.Add(player);

            return $"Successfully added player of type {type} with username: {username}";
        }
        

        public string AddCard(string type, string name)
        {
            ICard card = null;
            if (type == "Magic")
            {

                card = new MagicCard(name);
            }
            else if (type == "Trap")
            {
                card = new TrapCard(name);
            }

            this.cardRepository.Add(card);

            return $"Successfully added card of type {type}Card to user: {name}";
        }

        public string AddPlayerCard(string username, string cardName)
        {
            throw new NotImplementedException();
        }

        public string Fight(string attackUser, string enemyUser)
        {
            throw new NotImplementedException();
        }

        public string Report()
        {
            throw new NotImplementedException();
        }
    }
}

