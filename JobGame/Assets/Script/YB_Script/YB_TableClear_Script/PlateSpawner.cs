using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class PlateSpawner : MonoBehaviour
{
    [Serializable]
    public class PlateArray
    {
        [FormerlySerializedAs("_plate")] public GameObject[] plate;
    }
    [FormerlySerializedAs("_plateArray")] [SerializeField]
    private PlateArray[] plateArray;
    [SerializeField]private Transform[] platePos;
    void Start()
    {
        CreatePlate();
    }

    void CreatePlate()
    {
        Shuffle();
        for (int i = 0; i < 4; i++)
        {
            Instantiate(plateArray[i].plate[Random.Range(0,4)], platePos[i].position,quaternion.identity);
        }
    }

    void Shuffle()
    {
        for (int i = 0; i < plateArray.Length; ++i)
        {
            var random1 = Random.Range(0, plateArray.Length);
            var random2 = Random.Range(0, plateArray.Length);

            var temp = plateArray[random1];
            plateArray[random1] = plateArray[random2];
            plateArray[random2] = temp;
        }
    }
}
