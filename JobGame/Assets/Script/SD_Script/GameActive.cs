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

    //감자 갯수를 올려주는 버튼
    public GameObject potatoUpB;
    
    void OnMouseDown()
    {
        if(tag == "PotatoOven")
        {
            Gamenum ++;
            if(Gamenum == Plimit )
            {
                Instantiate(PotatoGame);
                StartCoroutine("PotatoG");
            }
        }
        else if(tag == "Dispenser")
        {
            DGamenum = +2;
            if(DGamenum == Dlimit )
            {
                Instantiate(DisPenserGame);
                Dispenserup.SetActive(true);
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
    IEnumerator PotatoG()
    {
        yield return new WaitForSeconds(1f);
        Potatoup.SetActive(true);
        yield return null;
    }
    IEnumerator DispenserG()
    {
        yield return new WaitForSeconds(1f);
        Dispenserup.SetActive(true);
        yield return null;
    }
}
