using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoGameActive : MonoBehaviour
{
    public GameObject PotatoGameObj;
    public GameObject PotatoUp;

    [SerializeField] bool PGameStart = false;

    void OnMouseDown()
    {
        if(tag == "PotatoOven" && PGameStart == false)
        {
            Instantiate(PotatoGameObj);
            PGameStart = true;
        }
    }

    public void PotatoReady()
    {
        PotatoUp.SetActive(true);
    }

    public void PotatoTrue()
    {
        PGameStart = true;
    }

    public void PGameFalse()
    {
        PGameStart = false;
    }
}
