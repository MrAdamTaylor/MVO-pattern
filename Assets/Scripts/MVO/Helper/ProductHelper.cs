using MVO;
using MVO.Product;
using StaticData;
using UnityEngine;
using Zenject;

public class ProductHelper : MonoBehaviour
{
    [SerializeField] private ProductInfo _productInfo;
    [SerializeField] private ProductPopup _productPopup;
    [SerializeField] private ProductCatalog _productCatalog;
    [SerializeField] private ShopPopup _shopPopup;
    private ProductBuyer _productBuyer;
    private MoneyStorage _moneyStorage;
    
    [Inject]
    private void Construct(ProductBuyer productBuyer, MoneyStorage moneyStorage)
    {
        _moneyStorage = moneyStorage;
        _productBuyer = productBuyer;
    }
    
    public void BuyProduct()
    {
        //_productBuyer.Buy(_productInfo);
    }

    public void ShowProductPopup()
    {
        var productPresenter = new ProductPresenter(_productInfo, _productBuyer, _moneyStorage);
        _productPopup.Show(productPresenter);
    }

    public void HideProductPopup()
    {
        _productPopup.Hide();
    }
}
