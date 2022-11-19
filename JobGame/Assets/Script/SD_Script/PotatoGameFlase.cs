using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PotatoGameFlase : MonoBehaviour
{

    float distance = 10f;
    player PlayerCs;

    void Awake()
    {
        PlayerCs = GameObject.Find("Player").GetComponent<player>();
        //플레이어 스크립트 불러오기.
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
            PlayerCs.potatoHave++;
            gameObject.SetActive(false);
            Vector2 thisPosition = new Vector2(5.44f,-2.32f);
        }
    }





}

   
    