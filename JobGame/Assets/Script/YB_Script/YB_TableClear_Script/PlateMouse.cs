using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlateMouse : MonoBehaviour
{
    [SerializeField] private int nowLevel;
    [SerializeField] private int stageTable;
    [SerializeField] private int nowStageTable;
    [SerializeField] private TextMeshProUGUI stageTableText;

    private void Start()
    {
        nowStageTable = 0;
        stageTable = Random.Range(3, 6);
        nowLevel = 5;
        stageTableText.text = $"{nowStageTable}/{stageTable}";
    }

    private void Update()
    {
        Click();
    }

    void Click()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main!.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero, 0f);
            if (hit)
            {
                if (hit.collider.CompareTag("Plate"))
                {
                    var plate = hit.transform.gameObject.GetComponent<Plate>();
                   
                    if (plate.GetPlateType() == nowLevel - 1)
                    {
                        nowLevel--;
                        Destroy(hit.collider.gameObject);
                    }
                    else
                    {
                        Debug.Log("hp--");
                    }
                    if (nowLevel == 1)
                    {
                        StartCoroutine(EndTable());
                    }
                }
            }
        }
    }

    IEnumerator EndTable()
    {
        nowStageTable++;
        stageTableText.text = $"{nowStageTable}/{stageTable}";
        if (nowStageTable >= stageTable)
        {
            stageTableText.text = $"End";
        }
        else
        {
            nowLevel = 5;
            Debug.Log("다음 상");
            yield return new WaitForSeconds(0.5f);
            var sp = GameObject.FindWithTag("Spawner").GetComponent<PlateSpawner>();
            sp.CreatePlate();
        }
    }
}
