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
    private ProductPresenterFactory _productPresenterFactory;
    
    [Inject]
    private void Construct(ProductBuyer productBuyer, ProductPresenterFactory productPresenterFactory)
    {
        _productBuyer = productBuyer;
        _productPresenterFactory = productPresenterFactory;
    }

    public void ShowProductPopup()
    {
        IProductPresenter productPresenter = _productPresenterFactory.Create(_productInfo);
        _productPopup.Show(productPresenter);
    }

    public void HideProductPopup()
    {
        _productPopup.Hide();
    }
}
