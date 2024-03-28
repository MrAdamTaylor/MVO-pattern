using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace MVO
{
    public class UIHelper : MonoBehaviour
    {
        [SerializeField] private long _current;
        private MoneyStorage _moneyStorage;
        
        [Inject]
        public void Construct(MoneyStorage moneyStorage)
        {
            _moneyStorage = moneyStorage;
        }
        
        public void AddMoney()
        {
            _moneyStorage.AddMoney(_current);
        }

        public void SpendMoney()
        {
            _moneyStorage.SpendMoney(_current);
        }
    }
}
