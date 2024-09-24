using DG.Tweening;
using TMPro;
using UnityEngine;

namespace MVO
{
    //TODO - View 
    public class CurrencyView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _currencyText;
        [SerializeField] private ScaleTweenParams _startScale;
        [SerializeField] private ScaleTweenParams _endScale;
        [SerializeField] private float _duration;
        public float Duration => _duration;
        
        private Sequence _sequence;
        private long _currentMoney;

        public Sequence AnimateStartText()
        {
            return DOTween
                .Sequence()
                .Append(_currencyText.transform.DOScale(_startScale.Scale, _startScale.Duration));
        }
        
        public Sequence AnimateEndText()
        {
            return DOTween
                .Sequence()
                .Append(_currencyText.transform.DOScale(_endScale.Scale, _endScale.Duration));
        }


        public void UpdateCurrency(string currency)
        {
            //AnimationText(_currentMoney, money);
            _currencyText.text = currency;
            //_currentMoney = money;
        }

        /*private void AnimationText(long moneyCurrent, long moneyNext)
        {
            _sequence?.Kill();
            _sequence = DOTween.Sequence();
            _sequence.Append(_text.transform.DOScale(_startScale.Scale, _startScale.Duration));
            var tweenerCore = DOTween.To(() => moneyCurrent, Setter, moneyNext, _duration);
            _sequence.Append(tweenerCore);
            _sequence.Append(_text.transform.DOScale(_endScale.Scale, _endScale.Duration));
        }*/


        /*private void Setter(long pnewvalue)
        {
            _text.text = pnewvalue.ToString();
        }

        private void OnDestroy()
        {
            _sequence?.Kill();
            _sequence = null;
        }*/
    }
}
