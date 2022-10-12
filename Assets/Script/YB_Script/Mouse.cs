using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
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
            if (hit.collider.CompareTag("Meat"))
            {
                var meatLevel = hit.transform.gameObject.GetComponent<Meat>().meatLevel;
                switch (meatLevel)
                {
                    case 0:
                        Debug.Log("raw meat");
                        break;
                    case 1:
                        Debug.Log("cooked meat");
                        break;
                    case 2:
                        Debug.Log("burnt meat");
                        break;
                }
            }
        }
    }
}
