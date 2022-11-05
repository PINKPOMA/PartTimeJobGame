using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrashGame : MonoBehaviour
{
    public GameObject Trash1;
    public GameObject Trash2;
    public GameObject Trash3;
    public GameObject Trash4;
    public GameObject Trash5;
    public GameObject Trash6;

    public GameObject TrashGameScreen;

    public Text Text;

    // Update is called once per frame
    void Update()
    {
        if (!Trash1.activeInHierarchy && !Trash2.activeInHierarchy && !Trash3.activeInHierarchy && !Trash4.activeInHierarchy && !Trash5.activeInHierarchy && !Trash6.activeInHierarchy)
            StartCoroutine("TrashGameSuccess");
    }

    int count = 0;

    void OnMouseDown()
    {
        if (++count >= 1) // 1번 실패시
            StartCoroutine("TrashGameFailure");
    }

    IEnumerator TrashGameSuccess()
    {
        Text.text = "Success!";
        Text.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        Text.gameObject.SetActive(false);
        Destroy(TrashGameScreen);
        yield return null;
    }

    IEnumerator TrashGameFailure()
    {
        Text.text = "Failure!";
        Text.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        Text.gameObject.SetActive(false);
        Destroy(TrashGameScreen);
        yield return null;
    }
}
