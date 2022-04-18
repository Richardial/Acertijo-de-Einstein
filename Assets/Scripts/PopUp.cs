using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUp : MonoBehaviour
{
    

    private void Start() {
        gameObject.SetActive(true);
    }

    public void show(){
        gameObject.SetActive(true);
    }

    public void close(){
        gameObject.SetActive(false);
    }
}
