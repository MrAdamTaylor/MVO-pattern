using MVO;
using MVO.Product;
using StaticData;
using UnityEngine;

public interface IPresenter
{
    
}

public interface IProductPresenter : IPresenter
{
    string Title { get;}
    string Description { get;}
    Sprite Icon { get;}
    object MoneyPrice { get;}
    bool CanBuy { get;}
    void Buy();
}

public class ProductPresenter : IProductPresenter
{
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
    }

    public void Buy()
    {
        if (CanBuy)
        {
            _productBuyer.Buy(_productInfo);
        }
    }
}