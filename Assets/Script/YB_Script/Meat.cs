using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;

public class Meat : MonoBehaviour
{
  private SpriteRenderer _meatSprite;
  public int meatLevel;
  private void Start()
  {
    StartCoroutine(Roast(Random.Range(0.5f, 1f))); //고기의 익는 시간을 랜덤하게 반환합니다.
    _meatSprite = GetComponent<SpriteRenderer>();
  }



  IEnumerator Roast(float timer)  
  {
    yield return new WaitForSeconds(timer);
    _meatSprite.DOColor(new Color(150f/255f, 75f/255f, 0), 1f); //고기가 익었을 시 갈색으로 변합니다. 이 때 클릭 시 점수가  올라갑니다.
    meatLevel = 1;
    yield return new WaitForSeconds(2f);
    _meatSprite.DOColor(new Color(0, 0, 0), 1f);//고기가 탔을 시 갈색으로 변합니다. 이 때 클릭 시 점수가 깎입니다.
    meatLevel = 2;
  }
}
