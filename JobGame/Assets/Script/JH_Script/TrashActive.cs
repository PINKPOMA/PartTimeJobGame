using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashActive : MonoBehaviour
{
    public GameObject TrashGame;
    int count = 0;
     
    void OnMouseDown()
    {
        if(tag == "Trash")
        {
            count = count % 2;
            count++;
            if (count == 1) {
                Instantiate(TrashGame);
            }
            else {
                Destroy(TrashGame);
            }
        }
    }
}
