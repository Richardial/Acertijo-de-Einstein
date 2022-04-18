using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pool : MonoBehaviour, IDropHandler
{

    public void OnDrop(PointerEventData eventData){
        string name = DragHandler.itemDragging.GetComponent<DragHandler>().getParent();
        GameObject parent = GameObject.Find(name);
        DragHandler.itemDragging.transform.SetParent(parent.transform);
    }
    
}
