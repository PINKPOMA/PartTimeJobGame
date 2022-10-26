using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potato : MonoBehaviour
{
    float distance = 10;
   public void OnMouseDrag() 
   {
    //마우스를 드래그 하면 감자 오브젝트가 움직이는 스크립트 입니다.
        Vector3 mousePosition = new Vector3(Input.mousePosition.x,
                                        Input.mousePosition.y,distance);
        Vector3 PotatoPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = PotatoPosition;
   }
}
