using System;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace MVO
{
    [Serializable]
    public struct ScaleTweenParams
    {
        public Vector3 Scale;
        public float RillRate;
    }

    public class Money : MonoBehaviour
    {
        public long Amount { get; private set; }

        [SerializeField] private TMP_Text _text;
        [SerializeField] private ScaleTweenParams _startScale;
        [SerializeField] private ScaleTweenParams _endScale;
        [SerializeField] private float _duration;
        private Sequence _sequence;

        public void UpdateMoney(long moneyCurrent)
        {
            AnimationText(Amount, moneyCurrent);
            Amount = moneyCurrent;
        }

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
        }
    }
}
