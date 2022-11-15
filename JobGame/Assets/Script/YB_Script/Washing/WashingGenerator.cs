using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class WashingGenerator : MonoBehaviour
{

    [SerializeField] private GameObject plate;
    [SerializeField] private int nowPlate = 0;
    [SerializeField] private int maxPlate = 0;
    [SerializeField] private Transform throwPos;

    private void Start()
    {
        maxPlate = Random.Range(10, 21);
        StartCoroutine(ThrowPlate());
    }

    IEnumerator ThrowPlate()
    {
        nowPlate++;
        GameObject tPlate = Instantiate(plate, throwPos.position, throwPos.rotation);
        tPlate.gameObject.GetComponent<Rigidbody2D>().velocity = tPlate.transform.right * 10f;
        if(maxPlate > nowPlate)
        {
            yield return new WaitForSeconds(1f);
            StartCoroutine(ThrowPlate());
        }
    }
    
    
}
