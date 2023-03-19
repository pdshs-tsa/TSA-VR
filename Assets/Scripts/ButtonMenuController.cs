using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenuController : MonoBehaviour
{
    public GameObject dog;
    public GameObject cat;

    public static ButtonMenuController INSTACNCE;
    // Start is called before the first frame update
    void Start()
    {
        INSTACNCE = this;
    }

    public static void cycle()
    {
        Debug.Log("cycled");
        var control = INSTACNCE.dog.GetComponent<AnimalControlScript>();
        control.nextDescription();
        control = INSTACNCE.cat.GetComponent<AnimalControlScript>();
        control.nextDescription();
    }

    public static void adoptDog()
    {
        
    }

    public static void adoptCat()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
