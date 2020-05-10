using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropItem : MonoBehaviour, IDropHandler
{
    CanvasGroup cg;
    private void Awake()
    {
        cg = GameObject.Find("RightHand").GetComponent<CanvasGroup>();
    }
    public void OnDrop(PointerEventData eventData)
    {

        Debug.Log("OnDrop");
        if(eventData.pointerDrag != null)
        {
            cg.blocksRaycasts = true;
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition; 
        }
    }

    
}
