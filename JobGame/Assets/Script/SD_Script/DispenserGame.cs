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
    public GameObject DispenserGameScreen;

    //텍스트
    public Text GoodText;
    GameActive GameActiveCs;
    
    void Start()
    {
        GameActiveCs = GameObject.Find("PotatoOven").GetComponent<GameActive>();
        GameActiveCs = GameObject.Find("Dispenser").GetComponent<GameActive>();

    }

    public void Update()
    {
        //코루틴 실행
        StartCoroutine("DispenserGameEnd");
    }

    IEnumerator DispenserGameEnd()
        {
            //콜라의 갯수를 올려주는 오브젝트의 활성화 함수를 불러오기.
            GameObject.FindWithTag("PotatoOven").GetComponent<GameActive>().DispenserReady();
            yield return new WaitForSeconds(0.5f);
            one.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            Too.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            End.SetActive(true);
            GoodText.gameObject.SetActive(true);
            yield return new WaitForSeconds(1f);
            GameActiveCs.PGameFalse();
            GoodText.gameObject.SetActive(false);
            
            Destroy(DispenserGameScreen);
        }
}
