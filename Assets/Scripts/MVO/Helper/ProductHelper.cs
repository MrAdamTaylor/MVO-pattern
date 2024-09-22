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
    
    [Inject]
    private void Construct(ProductBuyer productBuyer)
    {
        _productBuyer = productBuyer;
    }
    
    public void BuyProduct()
    {
        //_productBuyer.Buy(_productInfo);
        //throw new Exception("Buy logic button don't release");
    }

    public void ShowProductPopup()
    {
        _productPopup.Show(_productInfo);
    }

    public void HideProductPopup()
    {
        _productPopup.Hide();
    }
}
