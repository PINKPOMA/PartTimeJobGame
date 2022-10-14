using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public Vector3 cameraPosition;
    public GameObject target;
    public GameObject camera;
    private Vector3 velocity = Vector3.zero;

    
    //부드럽게 이동될 감도
    public float smoothTime = 0.3f;


   void Update()
   {
        if(tag == "right")
        {
            //X좌표 27.22로 이동해야함.
            if(Input.GetMouseButtonDown(0))
            {
                Vector3 rightPosition;
                rightPosition = new Vector3(27.22f,0,0);
                camera.transform.position = Vector3.SmoothDamp(camera.transform.position,rightPosition,ref velocity,smoothTime);
            }
        }
   }
}
