using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Verify : MonoBehaviour
{
    public GameObject[] slots;
    
    public GameObject pop;
    public Text txt;

    private void Start() {
        pop.SetActive(false);
    }

    public void verificar(){
        bool verificado = true;
        foreach(GameObject slot in slots){
            foreach(Transform child in slot.transform){
                DropSlot casilla = child.GetComponent<DropSlot>();
                if(casilla !=null){
                    if(casilla.item != casilla.correctItem){
                        verificado = false;
                    }
                }else{
                    verificado = false;
                }
            }
        }

        if(verificado){
            txt.text = "En efecto, el pez es la mascota del Aleman!";
        }else{
            txt.text = "Tu respuesta es errónea";
        }
        show();
    }

    public void show(){
        pop.SetActive(true);
    }

    public void close(){
        pop.SetActive(false);
    }

}
