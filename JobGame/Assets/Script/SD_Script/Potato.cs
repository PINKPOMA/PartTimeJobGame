using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potato : MonoBehaviour
{
    float distance = 10;

    //처음 감자 오브젝트는 랜덤으로 생성됩니다.
    void Start()
    {
        this.transform.position = new Vector3(Random.Range(-3f,3f),2f,0);
    }

    public void OnMouseDrag() 
    {
    //마우스를 드래그 하면 감자 오브젝트가 움직이는 스크립트 입니다.
        Vector3 mousePosition = new Vector3(Input.mousePosition.x,
                                        Input.mousePosition.y,distance);
        Vector3 PotatoPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = PotatoPosition;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Potato")
        {
            gameObject.SetActive(false);
        }
    }
}
