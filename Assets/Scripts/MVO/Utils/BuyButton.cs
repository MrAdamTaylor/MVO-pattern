using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    [SerializeField] private Button _button;

    [Space]
    [SerializeField] private Image _buttonBackground;

    [SerializeField] private Sprite _availableButtonSprite;

    [SerializeField] private Sprite _lockedButtonSprite;

    [Space]
    [SerializeField] private TextMeshProUGUI _priceText;

    [Space]
    [SerializeField]
    private BuyButtonState _state;

    private Image _priceIcon;

    public Button Button => _button;
}
