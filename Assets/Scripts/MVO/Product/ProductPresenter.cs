using MVO;
using MVO.Product;
using StaticData;
using UnityEngine;
using System;
using UniRx;

public class ProductPresenter : IProductPresenter
{
    public event Action OnButtonStateChanged; 
    
    public string Title { get; }
    public string Description { get; }
    public Sprite Icon { get; }
    public object MoneyPrice { get; }
    public bool CanBuy => _productBuyer.CanBuy(_productInfo);
    public ReactiveCommand BuyCommand { get; } = new ReactiveCommand();

    private readonly ProductInfo _productInfo;
    private readonly ProductBuyer _productBuyer;
    private readonly MoneyStorage _moneyStorage;
    private IDisposable _disposable;

    public ProductPresenter(ProductInfo productInfo, ProductBuyer productBuyer, MoneyStorage moneyStorage)
    {
        _productInfo = productInfo;
        _productBuyer = productBuyer;
        _moneyStorage = moneyStorage;
        
        Title = productInfo.Title;
        Description = productInfo.Description;
        Icon = productInfo.Icon;
        MoneyPrice = productInfo.MoneyPrice.ToString();
        _disposable = _moneyStorage.Money.Subscribe(OnMoneyChanged);
        BuyCommand = new ReactiveCommand();
        BuyCommand.Subscribe(OnBuyCommand);
    }

    public void OnBuyCommand(Unit _)
    {
        Buy();
    }
    
    private void OnMoneyChanged(long _)
    {
        OnButtonStateChanged?.Invoke();
    }

    public void Buy()
    {
        if (CanBuy)
        {
            _productBuyer.Buy(_productInfo);
        }
    }

    ~ProductPresenter()
    {
        _disposable.Dispose();
    }
}