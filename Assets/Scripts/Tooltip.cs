using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour
{
    public GameObject tool;

    public float x = 150;
    public float y = -50;

    private void Start() {
        tool.SetActive(false);
    }

    public void show(string text, Vector3 position){
        tool.SetActive(true);
        tool.transform.position = new Vector3(position.x+x,position.y+y,position.z);
        tool.transform.GetChild(0).GetComponent<Text>().text = text;
    }

    public void close(){
        tool.SetActive(false);
    }
}
