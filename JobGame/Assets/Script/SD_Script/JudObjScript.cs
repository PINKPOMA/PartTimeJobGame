using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudObjScript : MonoBehaviour
{
    //https://namwhis.tistory.com/entry/Unity%EC%9C%A0%EB%8B%88%ED%8B%B0-%EC%A0%95%EB%A6%AC-04-%EC%A2%8C%EC%9A%B0%EC%9D%B4%EB%8F%99-%EB%AC%B4%ED%95%9C%EB%B0%98%EB%B3%B5-TimedeltaTime-Timetime-MathfSin

    Vector3 Pos; //현재위치
    public float Delta = 1.4f; //좌우로 이동가능한 x최대값
    public float Speed = 3.0f; //이동속도

    void Start()
    {
        Pos = transform.position;
    }

    void Update()
    {
        Vector3 v = Pos;
        v.x += Delta * Mathf.Sin(Time.time*Speed);
        transform.position = v;
    }
}
