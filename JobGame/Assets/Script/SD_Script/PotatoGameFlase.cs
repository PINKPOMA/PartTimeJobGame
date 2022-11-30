using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PotatoGameFlase : MonoBehaviour
{

    float distance = 10f;
    player PlayerCs;
    GameActive GameActiveCs;


    void Awake()
    {
        PlayerCs = GameObject.Find("Player").GetComponent<player>();
        GameActiveCs = GameObject.Find("PotatoOven").GetComponent<GameActive>();
        //플레이어 스크립트,게임 엑티브 불러오기.
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
            GameActiveCs.PGameFalse();
            PlayerCs.potatoHave++;
            gameObject.SetActive(false);
        }
    }





}

   
    