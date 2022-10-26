using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Scenes : MonoBehaviour
{
    [FormerlySerializedAs("_sceneObject")] [SerializeField] private GameObject[] sceneObject;

    private void Start()
    {
        var count = sceneObject.Length;
        for (int i = 0; i < count; i++)
        {
            Instantiate(sceneObject[i], sceneObject[i].transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
