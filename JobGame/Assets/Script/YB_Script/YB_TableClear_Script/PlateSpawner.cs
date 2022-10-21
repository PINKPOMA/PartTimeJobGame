using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlateSpawner : MonoBehaviour
{
    [Serializable]
    public class PlateArray
    {
        [FormerlySerializedAs("_plate")] [SerializeField] private GameObject[] plate;
    }

    [FormerlySerializedAs("_plateArray")] [SerializeField]
    private PlateArray[] plateArray; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
