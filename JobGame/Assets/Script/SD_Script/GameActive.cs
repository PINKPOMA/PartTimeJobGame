using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameActive : MonoBehaviour
{
    public GameObject PotatoGame;
    public GameObject DisPenserGame;
    int Plimit = 1;
    int Dlimit = 2;
    int Gamenum = 0;
    
    void OnMouseDown()
    {
        if(tag == "PotatoOven")
        {
            Gamenum ++;
            if(Gamenum == Plimit )
            {
                Instantiate(PotatoGame);
            }
        }
        else if(tag == "Dispenser")
        {
            Gamenum = +2;
            if(Gamenum == Dlimit )
            {
                Instantiate(DisPenserGame);
            }
        }
    }
}
