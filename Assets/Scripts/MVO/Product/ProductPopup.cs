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

    private IProductPresenter _productPresenter;
    
    public void Show(IPresenter presenter)
    {
        if (presenter is not IProductPresenter productPresenter)
        {
            throw new InvalidDataException($"{nameof(productPresenter)} must be {nameof(IProductPresenter)}");
        }

        _productPresenter = productPresenter;

        _title.text = _productPresenter.Title;
        _description.text = _productPresenter.Description;
        _icon.sprite = _productPresenter.Icon;

        _byuButton.SetPrice(_productPresenter.MoneyPrice.ToString());
        _byuButton.AddListener(BuyProduct);
        _closeButton.onClick.AddListener(Hide);
        UpdateButton();
        gameObject.SetActive(true);
    }

    private void UpdateButton()
    {
        var buttonState = _productPresenter.CanBuy
            ? BuyButtonState.Available 
            : BuyButtonState.Locked;
        _byuButton.SetState(buttonState);
    }

    private void BuyProduct()
    {
        _productPresenter.Buy();
        UpdateButton();
    }

    public void Hide()
    {
        gameObject.SetActive(false);
        _byuButton.RemoveListener(BuyProduct);
        _closeButton.onClick.RemoveListener(Hide);
    }
}
