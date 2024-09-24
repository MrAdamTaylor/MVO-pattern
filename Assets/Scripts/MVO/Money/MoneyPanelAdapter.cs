using System;
using UniRx;
using UnityEngine;
using DG.Tweening;

namespace MVO
{
    //TODO - Presenter
    public sealed class MoneyPanelAdapter : IDisposable
    {
        private readonly CurrencyView _currencyView;
        private readonly MoneyStorage _moneyStorage;
        private readonly CompositeDisposable _disposable = new();

        public MoneyPanelAdapter(CurrencyView currencyView, MoneyStorage moneyStorage)
        {
            _currencyView = currencyView;
            _moneyStorage = moneyStorage;
            _moneyStorage.Money.SkipLatestValueOnSubscribe().Subscribe(OnMoneyChanged);
            Setter(_moneyStorage.Money.Value);
        }

        private long _lastCurrency;
        private Sequence _sequence;

        private void OnMoneyChanged(long money)
        {
            _sequence?.Kill();
            var tweenerCore = DOTween.To(() => _lastCurrency, Setter, money, _currencyView.Duration);
            _sequence = DOTween.Sequence();
            _sequence.Append(_currencyView.AnimateStartText());
            _sequence.Append(tweenerCore);
            _sequence.Append(_currencyView.AnimateEndText());
        }

        /*public void Initialize()
        {
            Debug.Log("Initialize Work");
            _moneyStorage.OnMoneyChanged += Setter;
        }*/

        private void Setter(long value)
        {
            _currencyView.UpdateCurrency(value.ToString());
            _lastCurrency = value;
        }

        public void Dispose()
        {
            _disposable.Dispose();
        }
    }
}