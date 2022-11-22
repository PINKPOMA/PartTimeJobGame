using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotatoGame : MonoBehaviour
{

    //포테이토 오브젝트
    public GameObject Potato1;
    public GameObject Potato2;
    public GameObject Potato3;
    public GameObject Potato4;
    public GameObject Potato5;

    //PotatoGame창
    public GameObject PotatoGameScreen;
    //텍스트
    public Text GoodText;
    //game을 Active 시켜주는 스크립트
    GameActive gameActiveCs;

    void Start()
    {
        gameActiveCs = GameObject.Find("PotatoOven").GetComponent<GameActive>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "PotatoObj1")
        {
            Potato1.SetActive(true);
        }
        if(other.name == "PotatoObj2")
        {
            Potato2.SetActive(true);
        }
        if(other.name == "PotatoObj3")
        {
           
            Potato3.SetActive(true);
        }
        if(other.name == "PotatoObj4")
        {
            
            Potato4.SetActive(true);
        }
        if(other.name == "PotatoObj5")
        {
            
            Potato5.SetActive(true);
        }
    }

    void Update()
    {
        if( Potato1.activeInHierarchy && Potato2.activeInHierarchy &&
        Potato3.activeInHierarchy && Potato4.activeInHierarchy && Potato5.activeInHierarchy)
        {
            StartCoroutine("PotatoGameEnd");
        }

    }

    IEnumerator PotatoGameEnd()
    {
        gameActiveCs.Gamenum = 0;
        GameObject.FindWithTag("PotatoOven").GetComponent<GameActive>().PotatoReady();
        GoodText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.4f);

        GoodText.gameObject.SetActive(false);
        PotatoGameScreen.SetActive(false);

        //먼저 활성화를 해제 하고 2초 뒤에 Destroy.
        yield return new WaitForSeconds(0.5f);
        Destroy(PotatoGameScreen);
        yield return null;
    }




}
