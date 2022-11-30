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

    GameActive GameActiveCs;

    //텍스트
    public Text GoodText;

    void Start()
    {
        GameActiveCs = GameObject.Find("PotatoOven").GetComponent<GameActive>();
        GameActiveCs = GameObject.Find("Dispenser").GetComponent<GameActive>();
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
        GameObject.FindWithTag("PotatoOven").GetComponent<GameActive>().PotatoReady();
        GoodText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.4f);
        GoodText.gameObject.SetActive(false);
        GameActiveCs.DGameFalse();
        Destroy(PotatoGameScreen);
    }




}
