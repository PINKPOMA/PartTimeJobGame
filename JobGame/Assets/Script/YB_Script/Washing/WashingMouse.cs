using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class WashingMouse : MonoBehaviour
{
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
                    var plate = hit.transform.gameObject.GetComponent<WashingPlate>();
                    plate.LevelUp();
                }
            }
        }
    }

}
