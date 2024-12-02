using System;

namespace ElectronicCardSystem
{
    public abstract class ElectronicCard
    {
        public abstract string GetFeatures();
    }

    public abstract class CardDecorator : ElectronicCard
    {
        protected ElectronicCard _card;

        public CardDecorator(ElectronicCard card)
        {
            _card = card;
        }

        public override string GetFeatures()
        {
            return _card.GetFeatures();
        }
    }
}
