using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameActive : MonoBehaviour
{

    //감자게임
    public GameObject PotatoGame;
    public GameObject Potatoup;

    //디스펜서 게임
    public GameObject DisPenserGame;
    public GameObject Dispenserup;

    //불값
    [SerializeField] bool PGameStart = false;
    [SerializeField] bool DGameStart = false;
   
    
    void OnMouseDown()
    {
        if(tag == "PotatoOven" && PGameStart == false && DGameStart == false)
        {  
                Instantiate(PotatoGame);
                PGameStart = true;
                DGameStart = true;
        }
        if(tag == "Dispenser" && DGameStart == false && PGameStart == false)
        {
                Instantiate(DisPenserGame);
                DGameStart = true;
                PGameStart = true;
        }
        
    }

    
    public void PotatoReady()
    {
        Potatoup.SetActive(true);
    }

    public void DispenserReady()
    {
        Dispenserup.SetActive(true);
    }

    public void PGameFalse()
    {
        PGameStart = false;
    }

    public void DGameFalse()
    {
        DGameStart = false;
    }


}
