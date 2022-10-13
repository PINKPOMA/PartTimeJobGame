using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orderScreenActive : MonoBehaviour
{   
    //오더 스크린
    public GameObject orderScreen; 

    //마우스 클릭하면 오더스크린 Active가 활성화됩니다.
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            orderScreen.SetActive(true);
            gameObject.GetComponent<Renderer>().material.color = Color.gray;

        }
    }
}
