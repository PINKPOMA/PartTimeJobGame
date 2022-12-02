using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HamburgerButton : MonoBehaviour
{
    public GameObject HamburgerObj;
    HamburgerObj HamburgerCs;

    void Start()
    {
        HamburgerCs = GetComponent<HamburgerObj>();
    }
    void OnMouseDown() 
    {
        /*if(HamburgerCs.HamburgerActive == false)
        {
            Instantiate(HamburgerObj);
        }*/
        //UI로 터치횟수 알아본 다음에 해야할듯.
        //터치횟수가 0이면 1로 카운트 올린다음에
        //Instatiate로 생성된 햄버거가 tray에 Trigger되면
        //다시 터치횟수가 0으로 초기화 되도록.
    }
}
