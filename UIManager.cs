using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    int currentAmmo = 28;
    int maxAmmo = 30;

    void Update()
    {
        // Reload with R
        if (Input.GetKeyDown("r"))
        {
            if (currentAmmo != maxAmmo)
                currentAmmo = maxAmmo;
        }
        // If no Bullets, can´t shoot
        if (currentAmmo != 0)
        {
            if (Input.GetMouseButtonDown(0))
                currentAmmo--;
        }
    }
    // This is your ammo counter
    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 150, 50), "Ammo: " + currentAmmo + " /  " + maxAmmo);
    }
}