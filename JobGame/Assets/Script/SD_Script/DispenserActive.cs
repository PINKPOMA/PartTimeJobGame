using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispenserActive : MonoBehaviour
{
    public GameObject DispenserGameObj;
    public GameObject DispenserUp;
    [SerializeField] bool DGameStart = false;

    void OnMouseDown()
    {
        if(tag == "Dispenser" && DGameStart == false)
        {
            Instantiate(DispenserGameObj);
            DGameStart = true;
        }
    }

    public void DispenserReady()
    {
        DispenserUp.SetActive(true);
    }

    public void DGameTrue()
    {
        DGameStart = true;
    }

    public void DGameFalse()
    {
        DGameStart = false;
    }
}
