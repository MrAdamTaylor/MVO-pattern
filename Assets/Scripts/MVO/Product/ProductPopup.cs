using System;
using System.IO;
using MVO;
using MVO.Product;
using StaticData;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ProductPopup : MonoBehaviour
{
    [SerializeField] private TMP_Text _title;
    [SerializeField] private TextMeshProUGUI _description;
    [SerializeField] private Image _icon;
    [SerializeField] private BuyButton _byuButton;
    [SerializeField] private Button _closeButton;
    private ProductInfo _productInfo;
    private ProductBuyer _productBuyer;
    private MoneyStorage _moneyStorage;

    [Inject]
    private void Construct(ProductBuyer productBuyer, MoneyStorage moneyStorage)
    {
        _moneyStorage = moneyStorage;
        _productBuyer = productBuyer;
    }
    
    public void Show(object args)
    {
        if (args is not ProductInfo productInfo)
        {
            throw new InvalidDataException($"Invalid data type: {args.GetType()}");
        }

        _productInfo = productInfo;

        _title.text = productInfo.Title;
        _description.text = productInfo.Description;
        _icon.sprite = productInfo.Icon;

        _byuButton.SetPrice(productInfo.MoneyPrice.ToString());
        _byuButton.AddListener(BuyProduct);
        gameObject.SetActive(true);
    }

    private void BuyProduct()
    {
        if (_productBuyer.CanBuy(_productInfo))
        {
            _productBuyer.Buy(_productInfo);
        }
    }

    public void Hide()
    {
        gameObject.SetActive(false);
        _byuButton.RemoveListener(BuyProduct);
    }
}
