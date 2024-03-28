using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace MVO
{
    public class UIHelper : MonoBehaviour
    {
        [SerializeField] private long _current;
        private MoneyStorage _moneyStorage;
        private GemStorage _gemStorage;

        [Inject]
        public void Construct(MoneyStorage moneyStorage, GemStorage gemStorage)
        {
            _gemStorage = gemStorage;
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
        
        public void AddGem()
        {
            _gemStorage.AddMoney(_current);
        }

        public void SpendGem()
        {
            _gemStorage.SpendMoney(_current);
        }
    }
}
