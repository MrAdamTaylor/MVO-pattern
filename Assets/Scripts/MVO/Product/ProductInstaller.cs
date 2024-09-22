using Zenject;

namespace MVO.Product
{
    public class ProductInstaller
    {
        public ProductInstaller(DiContainer container)
        {
            container.Bind<ProductBuyer>().AsSingle().NonLazy();
        }
    }
}