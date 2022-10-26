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
            Instantiate(PotatoGame);
        }
        else if(tag == "Dispenser")
        {
            Instantiate(DisPenserGame);
        }
    }
}
