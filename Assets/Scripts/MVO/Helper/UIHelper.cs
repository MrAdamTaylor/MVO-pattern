using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace MVO
{
    public class UIHelper : MonoBehaviour
    {
        private MoneyStorage _moneyStorage;
        [SerializeField] private long _monneyCurrent;

        [Inject]
        public void Construct(MoneyStorage moneyStorage)
        {
            _moneyStorage = moneyStorage;
        }
        
        public void AddMoney()
        {
            _moneyStorage.AddMoney(_monneyCurrent);
        }

        public void SpendMoney()
        {
            _moneyStorage.SpendMoney(_monneyCurrent);
        }
    }
}
