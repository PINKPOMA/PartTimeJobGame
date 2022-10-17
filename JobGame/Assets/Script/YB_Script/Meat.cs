using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;

public class Meat : MonoBehaviour
{
  private SpriteRenderer _meatSprite; // 고기의 색을 변경하기위해 스프라이트를 가져옵니다.
  public int meatLevel; // 고기의 익은 정도를 담을 변수입니다.
  private void Start()
  {
    StartCoroutine(Roast(Random.Range(0.5f, 1f))); // 고기의 익는 시간을 랜덤하게 반환합니다.
    _meatSprite = transform.GetChild(0).GetComponent<SpriteRenderer>(); // 이 오브젝트의 하위 오브젝트가 고기 스프라이트를 가지고 있기 때문에 하위 오브젝트를 찾아줍니다.
  }



  IEnumerator Roast(float timer)  
  {
    yield return new WaitForSeconds(timer);
    _meatSprite.DOColor(new Color(150f/255f, 75f/255f, 0), 1f); //고기가 익었을 시 갈색으로 변합니다. 이 때 클릭 시 점수가  올라갑니다.
    meatLevel = 1;
    yield return new WaitForSeconds(2f);
    _meatSprite.DOColor(new Color(0, 0, 0), 1f); // 고기가 탔을 시 갈색으로 변합니다. 이 때 클릭 시 점수가 깎입니다.
    meatLevel = 2;
  }
}
