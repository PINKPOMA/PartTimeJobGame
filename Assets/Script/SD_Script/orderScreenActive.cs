using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orderScreenActive : MonoBehaviour
{   
    //오더 스크린
    public GameObject orderScreen; 
    public BoxCollider2D boxcollider;

    void Awake()
    {
        boxcollider = GetComponent<BoxCollider2D>();
    }

    //마우스 클릭하면 오더스크린 Active가 활성화됩니다.
    private void OnMouseDown() 
    {
            orderScreen.SetActive(true);
            gameObject.GetComponent<Renderer>().material.color = Color.gray;
            
    }
}

