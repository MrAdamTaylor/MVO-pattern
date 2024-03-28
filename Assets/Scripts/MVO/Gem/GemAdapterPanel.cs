using System;
using System.Collections;
using System.Collections.Generic;
using MVO;
using UnityEngine;
using Zenject;

public class GemAdapterPanel : IInitializable, IDisposable
{
    private readonly CurrencyView _currencyView;
    private readonly GemStorage _moneyStorage;

    public GemAdapterPanel(CurrencyView currencyView, GemStorage moneyStorage)
    {
        _currencyView = currencyView;
        _moneyStorage = moneyStorage;
    }

    public void Initialize()
    {
        _moneyStorage.OnGemChanged += UpdateMoney;
    }

    private void UpdateMoney(long money)
    {
        _currencyView.UpdateCurrency(money);
    }

    public void Dispose()
    {
        _moneyStorage.OnGemChanged -= UpdateMoney;
    }
}
