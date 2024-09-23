using MVO;
using MVO.Product;
using StaticData;
using UnityEngine;
using System;

public class ProductPresenter : IProductPresenter
{
    public event Action OnButtonStateChanged; 
    
    public string Title { get; }
    public string Description { get; }
    public Sprite Icon { get; }
    public object MoneyPrice { get; }
    public bool CanBuy => _productBuyer.CanBuy(_productInfo);

    private readonly ProductInfo _productInfo;
    private readonly ProductBuyer _productBuyer;
    private readonly MoneyStorage _moneyStorage;

    public ProductPresenter(ProductInfo productInfo, ProductBuyer productBuyer, MoneyStorage moneyStorage)
    {
        _productInfo = productInfo;
        _productBuyer = productBuyer;
        _moneyStorage = moneyStorage;
        
        Title = productInfo.Title;
        Description = productInfo.Description;
        Icon = productInfo.Icon;
        MoneyPrice = productInfo.MoneyPrice.ToString();
        _moneyStorage.OnMoneyChanged += OnMoneyChanged;
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
        _moneyStorage.OnMoneyChanged -= OnMoneyChanged;
    }
}