using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI buttonText;
    [SerializeField] TextMeshProUGUI costText;
    [SerializeField] Transform visualPlace;
    [SerializeField] Button button;

    public void Init(SingleSkinSO skin)
    {
        buttonText.text = skin.Name;
        costText.text = skin.Price.ToString();
        Instantiate(skin.Visual, visualPlace);
    }
}
