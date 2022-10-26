using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoGame : MonoBehaviour
{
    //포테이토 오브젝트
    public GameObject Potato1;
    public GameObject Potato2;
    public GameObject Potato3;
    public GameObject Potato4;
    public GameObject Potato5;



    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "PotatoObj1")
        {
            Debug.Log("감자1");
            Potato1.SetActive(true);
        }
        if(other.name == "PotatoObj2")
        {
            Debug.Log("감자2");
            Potato2.SetActive(true);
        }
        if(other.name == "PotatoObj3")
        {
            Debug.Log("감자3");
            Potato3.SetActive(true);
        }
        if(other.name == "PotatoObj4")
        {
            Debug.Log("감자4");
            Potato4.SetActive(true);
        }
        if(other.name == "PotatoObj5")
        {
            Debug.Log("감자5");
            Potato5.SetActive(true);
        }
    }
}
