using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public static GameObject itemDragging;
    public static Vector3 startPosition;
    Transform startParent;
    Transform dragParent;

    Tooltip tool;

    [SerializeField]
    public string originalParent;
    
    void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
        originalParent = transform.parent.name;
        tool = GetComponent<Tooltip>();
        
    }

    public void OnBeginDrag(PointerEventData eventData){
        Debug.Log(originalParent);
        itemDragging = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        transform.SetParent(dragParent);
        
    }
    public void OnDrag(PointerEventData eventData){
        transform.position = Input.mousePosition;
        tool.show(gameObject.name, Input.mousePosition);
    }
    
    public void OnEndDrag(PointerEventData eventData){
        itemDragging = null;
        tool.close();
        if(transform.parent == dragParent){
            transform.position = startPosition;
            transform.SetParent(startParent);
        }
    }

    public string getParent(){
        return originalParent;
    }
}
