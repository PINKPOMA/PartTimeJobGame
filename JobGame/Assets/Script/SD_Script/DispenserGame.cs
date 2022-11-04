using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DispenserGame : MonoBehaviour
{

    //콜라 GameObject
    public GameObject one;
    public GameObject Too;
    public GameObject End;

    //디스팬서 게임 오브젝트
    public GameObject DispenserGameObj;

    //텍스트
    public Text GoodText;

public void Update()
    {
            StartCoroutine("DispenserGameEnd");
    }
    IEnumerator DispenserGameEnd()
        {
            yield return new WaitForSeconds(0.5f);
            one.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            Too.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            End.SetActive(true);
            GoodText.gameObject.SetActive(true);
            yield return new WaitForSeconds(1f);
            Destroy(DispenserGameObj);
            yield return null;
        }
}
