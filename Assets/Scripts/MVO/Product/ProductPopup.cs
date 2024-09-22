using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProductPopup : MonoBehaviour
{
    [SerializeField] 
    private TMP_Text _title;

    [SerializeField] 
    private TextMeshProUGUI _description;

    [SerializeField] 
    private Image _icon;

    [SerializeField] 
    private BuyButton _byuButton;

    [SerializeField] 
    private Button _closeButton;


    public void Show(object args)
    {
        gameObject.SetActive(true);
    }
    
    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
