using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.Cards.Contracts;
using PlayersAndMonsters.Models.Players;
using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Models.BattleFields
{
    public class BattleField : IBattleField
    {
        ICardRepository cardRepository;

        public BattleField()
        {
            // to  initialize card repo - 
        }

        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }

            if (attackPlayer is Begginer)
            {
                attackPlayer.Health += 40;

                cardRepository = attackPlayer.CardRepository;

                foreach (var item in cardRepository.Cards)
                {
                    item.DamagePoints += 30;
                }
            }

            // •	Before the fight, both players get bonus health points from their deck 
            // dont know what that means ^^

            while (!attackPlayer.IsDead || !enemyPlayer.IsDead)
            {
                ICard currentCard = attackPlayer.CardRepository.Cards.FirstOrDefault();

                if (currentCard != null)
                {
                    enemyPlayer.TakeDamage(currentCard.DamagePoints);
                }

                ICard enemyCard = enemyPlayer.CardRepository.Cards.FirstOrDefault();

                if(enemyCard != null)
                {
                    attackPlayer.TakeDamage(enemyCard.DamagePoints);
                }
            }
        }
    }
}
