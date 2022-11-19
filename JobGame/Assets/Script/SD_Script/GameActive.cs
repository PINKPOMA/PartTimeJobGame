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
    int Gamenum = 0;
    int DGamenum = 0;

    //감자게임 오브젝트 스크립트
    PotatoGame potatogameCs;
    GameObject potatogameObj;
    public GameObject PotatoGameObj;

    void Start()
    {
        potatogameObj = PotatoGameObj.transform.GetChild(PotatoGame);
        potatogameCs = potatogameObj.GetComponent<PotatoGame>();

    }
    void OnMouseDown()
    {
        if(tag == "PotatoOven")
        {
            Gamenum ++;
            if(Gamenum == Plimit)
            {
                Instantiate(PotatoGame);
            }
        }
        else if(tag == "Dispenser")
        {
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

    void FixedUpdate()
    {
        if(potatogameCs.PFlase == true)
         {
            Potatoup.SetActive(true);
         }
    }
    IEnumerator DispenserG()
    {
        
        Dispenserup.SetActive(true);
        yield return null;
    }
}
