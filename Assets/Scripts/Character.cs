using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public GameObject inventory;

	void Update () {

        if (Input.GetKeyDown("b"))
        {
            if (inventory.activeInHierarchy == false)
            {
                inventory.SetActive(true);
            }
            else
            {
                inventory.SetActive(false);
            }
        }

	}
}
