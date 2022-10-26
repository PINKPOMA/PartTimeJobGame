using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameActive : MonoBehaviour
{
    public GameObject PotatoGame;
    public GameObject DisPenserGame;
    void OnMouseDown()
    {
        if(tag == "PotatoOven")
        {
            PotatoGame.SetActive(true);
        }
        else if(tag == "Dispenser")
        {
            DisPenserGame.SetActive(true);
        }
    }
}
