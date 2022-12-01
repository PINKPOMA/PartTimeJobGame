using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HamburgerButton : MonoBehaviour
{
    public GameObject HamburgerObj;

    void OnMouseDown() 
    {
        Instantiate(HamburgerObj);
    }
}
