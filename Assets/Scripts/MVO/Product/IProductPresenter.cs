using System;
using UnityEngine;

public interface IProductPresenter : IPresenter
{
    public event Action OnButtonStateChanged; 
    
    string Title { get;}
    string Description { get;}
    Sprite Icon { get;}
    object MoneyPrice { get;}
    bool CanBuy { get;}
    void Buy();
}