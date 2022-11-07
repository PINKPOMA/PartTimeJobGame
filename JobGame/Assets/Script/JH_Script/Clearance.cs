using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clearance : MonoBehaviour
{
    public GameObject ClearanceGame;
    int count = 0;
     
    void OnMouseDown()
    {
        count = count % 2;
        count++;
        if (count == 1) {
            Instantiate(ClearanceGame);
        }
        else {
            Destroy(ClearanceGame);
        }
    }
}
