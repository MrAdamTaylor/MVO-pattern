using UnityEngine;

namespace MVO
{
    public class UIHelper : MonoBehaviour
    {
        [SerializeField] private Money _money;
        [SerializeField] private long _monneyCurrent;

        public void AddMoney()
        {
            var moneyCurrent = _money.Amount + _monneyCurrent;

            _money.UpdateMoney(moneyCurrent);
        }

        public void SpendMoney()
        {
            var moneyCurrent = _money.Amount - _monneyCurrent;

            _money.UpdateMoney(moneyCurrent);
        }
    }
}
