using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PotatoGameFlase : MonoBehaviour
{

    float distance = 10f;
    player PlayerCs;
    PotatoGameActive PotatoGameActiveCs;
    public Transform Target;



    void Awake()
    {
        PlayerCs = GameObject.Find("Player").GetComponent<player>();
        PotatoGameActiveCs = GameObject.Find("PotatoOven").GetComponent<PotatoGameActive>();
        //플레이어 스크립트,게임 엑티브 불러오기.
    }

    void Update()
    {
        if(!gameObject.activeInHierarchy)
        {
            transform.position = Target.position;
        }
    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x,Input.mousePosition.y,distance);
        Vector3 PotatoupPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = PotatoupPosition;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Tray")
        {
            PotatoGameActiveCs.PGameFalse();
            PlayerCs.potatoHave++;
            gameObject.SetActive(false);
        }
    }





}

   
    