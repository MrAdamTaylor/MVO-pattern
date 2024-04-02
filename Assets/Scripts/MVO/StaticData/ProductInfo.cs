using UnityEngine;

namespace StaticData
{
    [CreateAssetMenu(fileName = "Product", menuName = "Data/UI/New Product")]
    public class ProductInfo : ScriptableObject
    {
        [SerializeField] private Sprite _icon;
        [SerializeField] private string _title;
        [SerializeField] [TextArea(3, 5)] private string _description;
        [Space] 
        [SerializeField] private int _moneyPrice;
    
        public Sprite Icon => _icon;

        public string Title => _title;

        public string Description => _description;

        public int MoneyPrice => _moneyPrice;
    }
}
