using UnityEngine;
using UnityEngine.EventSystems;

public class onClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool myBool;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        myBool = true;
        Debug.Log("pointer down");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        myBool = false;
        Debug.Log("pointer up");
    }
}