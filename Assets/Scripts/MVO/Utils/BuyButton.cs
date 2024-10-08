using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
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

    public void AddListener(UnityAction action)
    {
        Button.onClick.AddListener(action);
    }

    public void RemoveListener(UnityAction action)
    {
        Button.onClick.RemoveListener(action);
    }

    public void SetPrice(string price)
    {
        _priceText.text = price;
    }

    public void SetState(BuyButtonState state)
    {
        _state = state;

        switch (state)
        {
            case BuyButtonState.Available:
                Button.interactable = true;
                _buttonBackground.sprite = _availableButtonSprite;
                break;
            case BuyButtonState.Locked:
                Button.interactable = false;
                _buttonBackground.sprite = _lockedButtonSprite;
                break;
            default:
                throw new Exception($"Undefined button state {state}!");
        }
    }
}
