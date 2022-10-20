using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceBarJudActive : MonoBehaviour
{
    public GameObject SpacebarJud;

    private void OnMouseDown() 
    {
        SpacebarJud.SetActive(true);
    }
}
