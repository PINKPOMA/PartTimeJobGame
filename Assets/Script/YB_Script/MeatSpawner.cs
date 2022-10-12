using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class MeatSpawner : MonoBehaviour
{
    private int _meatCount;
    [SerializeField] private float maxYPos;
    [SerializeField] private float maxXPos;
    [SerializeField] private GameObject meatObject;

    public void MeatSpawn()
    {
        if (_meatCount > 9) return;
        Debug.Log(-maxXPos + "//" + -1 * maxXPos);
        Instantiate(meatObject, 
            new Vector2(Random.Range(-1 * maxXPos, maxXPos), Random.Range(-1 * maxYPos, maxYPos)),
            quaternion.identity);
    }
}
