using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{   
    //이동할 좌표
    public Vector3 RTarget;
    public Vector3 LTarget;


    void Update()
    {
        //D를 누르면 RTarget Position으로 이동됩니다.
        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.position = RTarget;
        }
        //A를 누르면 LTarget Position으로 이동됩니다.
        else if(Input.GetKeyDown(KeyCode.A))
        {
            transform.position = LTarget;
        }
    }
}


