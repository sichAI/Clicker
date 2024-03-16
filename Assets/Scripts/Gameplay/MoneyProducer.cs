using System;

namespace Gameplay
{
    public abstract class MoneyProducer : Clickable
    {
        private int _product;

        public Action<int> MoneyProduced { get; set; }

        public void Construct(int product)
        {
            _product = product;
        }

        protected override void OnClicked()
        {
            MoneyProduced.Invoke(_product);
        }
    }
}