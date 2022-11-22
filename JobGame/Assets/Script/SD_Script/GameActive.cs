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

    //무한 게임 생성 방지를 위한
    int Plimit = 1;
    int Dlimit = 2;
    public int Gamenum = 0;
    public int DGamenum = 0;

    //감자게임 오브젝트 스크립트
    PotatoGame potatogameCs;
    GameObject potatogame;
    
    void OnMouseDown()
    {
        if(tag == "PotatoOven")
        {  
            //무한 게임 시작 방지 조건문
            Gamenum ++;
            if(Gamenum == Plimit && !Potatoup.activeInHierarchy)
            {
                Instantiate(PotatoGame);
            }
        }
        else if(tag == "Dispenser")
        {
            //무한 게임 시작 방지 조건문
            DGamenum = +2;
            if(DGamenum == Dlimit && !Dispenserup.activeInHierarchy )
            {
                Instantiate(DisPenserGame);
               
                StartCoroutine("DispenserG");
            }
        
        }
        
    }

    void Update()
    {
        if(!Potatoup.activeInHierarchy)
        {
            Plimit = 1;
            Gamenum = 0;
        }
        else if(!Dispenserup.activeInHierarchy)
        {
            Dlimit = 2;
            DGamenum = 0;
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
    
    IEnumerator DispenserG()
    {
        
        Dispenserup.SetActive(true);
        yield return null;
    }
}
