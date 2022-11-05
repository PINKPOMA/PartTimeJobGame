using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    void Start()
    {
        this.transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(-3f,3f),0);
    }

    void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
}
