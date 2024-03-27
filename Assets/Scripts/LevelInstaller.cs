using MVO;
using Zenject;

namespace DefaultNamespace
{
    public class LevelInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            MoneyBind();
        }

        private void MoneyBind()
        {
            Container.Bind<MoneyStorage>().
                AsSingle().
                WithArguments(10L).
                NonLazy();
        }
    }
}