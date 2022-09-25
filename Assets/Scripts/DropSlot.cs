using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropSlot : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public GameObject correctItem;
    public Image paw;

    string originalParent;
    void Start()
    {
        originalParent = correctItem.transform.parent.name;        
    }

    public void OnDrop(PointerEventData eventData)
    {
        // Debug.Log(originalParent);
        if (!item)
        {
            item = DragHandler.itemDragging;
            if(item.GetComponent<DragHandler>().getParent() == originalParent){
                item.transform.SetParent(transform);
                item.transform.position = transform.position;
                if(paw !=null)
                    paw.enabled = false;
             }
        }
    }

    void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null;
            if(paw !=null)
                paw.enabled = true;
        }
    }
}
