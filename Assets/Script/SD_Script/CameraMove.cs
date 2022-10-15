using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{   
    //부드럽게 이동될 감도
    public float smoothTime = 10f;
    
    //이동할 타겟
    public Vector3 target;

    //속도
    private float xVelocity = 30f;
    private float yVelocity = 0;

    void Update() 
    {   
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray,out hit))
        {
            if(hit.transform.gameObject.tag == "Right")
            {
            Debug.Log("오른쪽 화면 클릭");
            float newPositioX = Mathf.SmoothDamp(transform.position.x,target.x,ref xVelocity,smoothTime);        
            float newPositioY = Mathf.SmoothDamp(transform.position.y,target.y,ref yVelocity,smoothTime);
            transform.position = new Vector3(newPositioX,newPositioY,transform.position.z);
            }
        }
    }
}


