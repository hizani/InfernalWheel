using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScreenChanger : MonoBehaviour
{
    Image image;
    bool IsGoingToRed;
    byte GreenInt = 255;
    byte BlueInt = 255;
    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        if (IsGoingToRed)
        {
            GreenInt -= 1;
            BlueInt -= 1;
            image.color = new Color32(255, GreenInt, BlueInt, 255);
            if (GreenInt == 0)
                IsGoingToRed = false;
        }
        else
        {
            GreenInt += 1;
            BlueInt += 1 ;
            image.color = new Color32(255, GreenInt, BlueInt, 255);
            if (GreenInt == 255)
                IsGoingToRed = true;
        }
    }
}
