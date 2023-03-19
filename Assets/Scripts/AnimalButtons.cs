using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AnimalButtons : MonoBehaviour
{
    public void adoptDogButton()
    {
        SendMessageUpwards("adoptDog");
    }
    
    public void adoptCatButton()
    {
        SendMessageUpwards("adoptCat");
    }

    public void cycleButton()
    {
        ButtonMenuController.cycle();
    }
    
    public static void BroadcastAll(string fun) {
        GameObject[] gos = (GameObject[])GameObject.FindObjectsOfType(typeof(GameObject));
        foreach (GameObject go in gos) {
            if (go && go.transform.parent == null) {
                go.gameObject.BroadcastMessage(fun, SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}
