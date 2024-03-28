using Unity.VisualScripting;
using UnityEngine;

namespace MVO
{
    public class CurrencyProvider : MonoBehaviour
    {
        [SerializeField] private CurrencyView _moneyView;
        [SerializeField] private CurrencyView _gemView;

        public CurrencyView GemView => _gemView;
        public CurrencyView MoneyView => _moneyView;
    }
}