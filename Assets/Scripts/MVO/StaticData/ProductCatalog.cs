using UnityEngine;

namespace StaticData
{
    [CreateAssetMenu(fileName = "ProductCatalog", menuName = "Data/UI/ProductCatalog")]
    public class ProductCatalog : ScriptableObject
    {
        public ProductInfo[] Products;
    }
}
