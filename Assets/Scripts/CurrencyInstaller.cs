using MVO;
using UnityEngine;
using Zenject;

namespace DefaultNamespace
{
    public class CurrencyInstaller
    {
        public CurrencyInstaller(DiContainer container)
        {
            var view = Object.FindObjectOfType<CurrencyProvider>();
            Debug.Log("Is Zenject container "+container);
            Debug.Log("Currency view "+view);
            MoneyBind(container, view.MoneyView);
            GemBind(container, view.GemView);
        }
        
        private static void MoneyBind(DiContainer diContainer, CurrencyView viewMoneyView)
        {
            diContainer
                .Bind<MoneyStorage>()
                .AsSingle()
                .WithArguments(10L)
                .NonLazy();

            diContainer.BindInterfacesTo<MoneyPanelAdapter>().AsSingle().WithArguments(viewMoneyView).NonLazy();
        }

        private static void GemBind(DiContainer diContainer, CurrencyView viewGemView)
        {
            diContainer
                .Bind<GemStorage>()
                .AsSingle()
                .WithArguments(10L)
                .NonLazy();

            diContainer.BindInterfacesTo<GemAdapterPanel>().AsSingle().WithArguments(viewGemView).NonLazy();
        }
    }
}