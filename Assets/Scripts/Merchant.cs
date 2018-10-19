using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merchant : BaseNpc {

    public GameObject ShopLayer;


    private void OnTriggerEnter(Collider other)
    {
        var counter = 0;
        if (counter == 0)
        {
            Debug.Log("Oh Hallo!");
            counter++;
            ShopLayer.SetActive(true);
            //Instantiate Shop
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Exit Shop
        ShopLayer.SetActive(false);
        Debug.Log("Tschüss!");
    }
}
