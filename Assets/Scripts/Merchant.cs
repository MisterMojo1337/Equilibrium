using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merchant : BaseNpc {

    private void OnTriggerEnter(Collider other)
    {
        var counter = 0;
        if (counter == 0)
        {
            Debug.Log("Oh Hallo!");
            counter++;
            //Instantiate Shop
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Exit Shop
        Debug.Log("Tschüss!");
    }
}
