using UnityEngine;
using UnityEngine.EventSystems;
public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    //private static LTDescr delay;
    public InventoryItem InfoToDisplay;
    public string header;
    [Multiline()]
    public string content;

    

    public void OnPointerEnter(PointerEventData eventData)
    {
        //delay = LeanTween.delayedCall(0.5f, () =>
        //{
        //    TooltipSystem.Show(InfoToDisplay.item.description, InfoToDisplay.item.name);
        //});
        TooltipSystem.Show(InfoToDisplay.item.description, InfoToDisplay.item.name);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //LeanTween.cancel(delay.uniqueId);
        TooltipSystem.Hide();
    }
}
