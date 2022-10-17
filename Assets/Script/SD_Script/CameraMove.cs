using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{   
    //오른쪽으로 움직이는 좌표입니다.
    public Vector3 Rtarget;

    public Vector3 Ltarget;
    public GameObject orderScreen;
    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.position = Rtarget;
            orderScreen.SetActive(false);
        }    
        else if(Input.GetKeyDown(KeyCode.A))
        {
            transform.position = Ltarget;
        }
    }

}


