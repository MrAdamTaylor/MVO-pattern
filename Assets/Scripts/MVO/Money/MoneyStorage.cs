using System;
using UniRx;
using UnityEngine;

namespace MVO
{
    //TODO - Model
    public sealed class MoneyStorage
    {
        public IReadOnlyReactiveProperty<long> Money => _money;
        private ReactiveProperty<long> _money;

        //public event Action<long> OnMoneyChanged;


        public MoneyStorage(long money)
        {
            _money = new ReactiveProperty<long>(money);
        }

        public void AddMoney(long money)
        {
            _money.Value += money;
            //OnMoneyChanged?.Invoke(Money);
        }

        public void SpendMoney(long money)
        {
            _money.Value -= money;
            //OnMoneyChanged?.Invoke(Money);
        }
    }
}
