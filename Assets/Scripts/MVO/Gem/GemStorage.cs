using System;

namespace MVO
{
    public sealed class GemStorage
    {
        public event Action<long> OnGemChanged;
            
        public long Gem { get; private set; }
    
        public GemStorage(long gem)
        {
            Gem = gem;
        }
    
        public void AddMoney(long money)
        {
            Gem += money;
            OnGemChanged?.Invoke(Gem);
        }
    
        public void SpendMoney(long money)
        {
            Gem -= money;
            OnGemChanged?.Invoke(Gem);
        }
    }
}