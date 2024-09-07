using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ByuButton : MonoBehaviour
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