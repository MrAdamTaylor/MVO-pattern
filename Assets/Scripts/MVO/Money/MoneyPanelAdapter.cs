using System;
using Unity.VisualScripting;
using UnityEngine;
using IInitializable = Zenject.IInitializable;

namespace MVO
{
    //TODO - Presenter
    public sealed class MoneyPanelAdapter : IInitializable, IDisposable
    {
        private readonly CurrencyView _currencyView;
        private readonly MoneyStorage _moneyStorage;

        public MoneyPanelAdapter(CurrencyView currencyView, MoneyStorage moneyStorage)
        {
            _currencyView = currencyView;
            _moneyStorage = moneyStorage;
        }

        public void Initialize()
        {
            Debug.Log("Initialize Work");
            _moneyStorage.OnMoneyChanged += UpdateMoney;
        }

        private void UpdateMoney(long money)
        {
            _currencyView.UpdateCurrency(money);
        }

        public void Dispose()
        {
            Debug.Log("Dispose Work");
            _moneyStorage.OnMoneyChanged -= UpdateMoney;
        }
    }
}