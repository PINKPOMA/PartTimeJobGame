using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{   
    //이동할 타겟
    public Vector3 Ltarget;
    public Vector3 Rtarget;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.position = Rtarget;
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {
            transform.position = Ltarget;
        }
    }
}


