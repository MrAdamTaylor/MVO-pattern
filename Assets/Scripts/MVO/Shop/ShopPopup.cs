using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopPopup : MonoBehaviour
{
    [SerializeField] private Transform _container;
    [SerializeField] private ProductView _viewPrefab;
    [SerializeField] private Button _hideButton;
}

public class ProductView : MonoBehaviour
{
    [SerializeField] private ByuButton _button;

    [SerializeField] private TextMeshProUGUI _titileText;
}

internal class ByuButton : MonoBehaviour
{
    [SerializeField] private Button _button;

    [Space] 
    [SerializeField] private Image _buttonBackground;

    [SerializeField] private Sprite _availableButtonSprite;

    [Space] 
    [SerializeField] private TextMeshProUGUI _priceText;

    [Space] 
    [SerializeField] private BuyButtonState _state;
}

public enum BuyButtonState
{
    None = 0,
    Available = 1,
    Locked = 2,
            
}
