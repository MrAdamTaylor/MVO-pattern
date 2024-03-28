using DG.Tweening;
using TMPro;
using UnityEngine;

namespace MVO
{
    //TODO - View 
    public class CurrencyView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        [SerializeField] private ScaleTweenParams _startScale;
        [SerializeField] private ScaleTweenParams _endScale;
        [SerializeField] private float _duration;
        private Sequence _sequence;
        private long _currentMoney;

        private void AnimationText(long moneyCurrent, long moneyNext)
        {
            _sequence?.Kill();
            _sequence = DOTween.Sequence();
            _sequence.Append(_text.transform.DOScale(_startScale.Scale, _startScale.RillRate));
            var tweenerCore = DOTween.To(() => moneyCurrent, Setter, moneyNext, _duration);
            _sequence.Append(tweenerCore);
            _sequence.Append(_text.transform.DOScale(_endScale.Scale, _endScale.RillRate));
        }

        private void Setter(long pnewvalue)
        {
            _text.text = pnewvalue.ToString();
        }

        private void OnDestroy()
        {
            _sequence?.Kill();
            _sequence = null;
        }

        public void UpdateCurrency(long money)
        {
            AnimationText(_currentMoney, money);
            _currentMoney = money;
        }
    }
}
