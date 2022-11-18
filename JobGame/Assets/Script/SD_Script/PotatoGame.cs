using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotatoGame : MonoBehaviour
{

    //시간
    float time;
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

    //코루틴이 실행중인지 확인해주는 불값
    public bool PFlase = false;

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

    //다 한것과 상관없이 5초가 지나면 무조건 창이 없어지도록.
    void Update()
    {
        time = Time.deltaTime;
        if(time < 5 && Potato1.activeInHierarchy && Potato2.activeInHierarchy &&
        Potato3.activeInHierarchy && Potato4.activeInHierarchy && Potato5.activeInHierarchy)
        {
            StartCoroutine("PotatoGameEnd");
        }

        else if(time > 5)
        {
            StartCoroutine("PotatoGameBed");
        }
    }

    IEnumerator PotatoGameEnd()
    {
        PFlase = true;
        GoodText.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        GoodText.gameObject.SetActive(false);
        PotatoGameScreen.SetActive(false);
        yield return new WaitForSeconds(5.0f);
        PFlase = false;
        yield return null;
    }




}
