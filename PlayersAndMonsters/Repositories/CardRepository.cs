﻿using PlayersAndMonsters.Models.Cards.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayersAndMonsters.Repositories
{
    public class CardRepository : ICardRepository
    {
        private readonly List<ICard> cards;

        public CardRepository()
        {
            cards = new List<ICard>();
        }
        public int Count => Cards.Count;

        public IReadOnlyCollection<ICard> Cards => this.cards.AsReadOnly();

        public void Add(ICard card)
        {
            if (card == null)
            {
                throw new ArgumentException("Card cannot be null");
            }
            if (Cards.Any(x => x.Name == card.Name))
            {
                throw new ArgumentException($"Card {card.Name} already exists!");
            }

            this.cards.Add(card);
        }

        public ICard Find(string name)
        {
            var card = Cards.FirstOrDefault(x => x.Name == name);
            return card;
        }

        public bool Remove(ICard card)
        {
            if (card == null)
            {
                throw new ArgumentException($"Card canno be null");
            }

            return this.cards.Remove(card);
        }
    }
}
