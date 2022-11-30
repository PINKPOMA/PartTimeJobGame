using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispenserGameFalse : MonoBehaviour
{
    //PotatoGameFalse와 거의 동일한 스크립트 입니다.
    float distance = 10f;
    player PlayerCs;
    GameActive GameActiveCs;
     
    void Awake()
    {
        GameActiveCs = GameObject.Find("Dispenser").GetComponent<GameActive>();
        PlayerCs = GameObject.Find("Player").GetComponent<player>();
        //플레이어 스크립트 불러오기.
    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x,Input.mousePosition.y,distance);
        Vector3 PepsiPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = PepsiPosition;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Tray")
        {
            PlayerCs.PepsiHave ++;
            GameActiveCs.DGameFalse();
        }
    }
   
}
