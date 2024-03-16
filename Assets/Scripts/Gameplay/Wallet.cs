using System;
using UnityEngine;

namespace Gameplay
{
    public class Wallet : MonoBehaviour
    {
        private int _money;

        public Action<int> MoneyChanged { get; set; }

        public void Construct(params MoneyProducer[] moneyProducers)
        {
            foreach (MoneyProducer moneyProducer in moneyProducers)
            {
                moneyProducer.MoneyProduced += AddMoney;
            }
        }

        private void AddMoney(int money)
        {
            _money += money;
            MoneyChanged?.Invoke(_money);
        }
    }
}