using MVO.Product;
using Zenject;

namespace DefaultNamespace
{
    public class LevelInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            new CurrencyInstaller(Container);
            new ProductInstaller(Container);
        }

        
    }
}