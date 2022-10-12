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
            if (hit)
            {
                if (hit.collider.CompareTag("Meat"))
                {
                    var meat = hit.transform.gameObject.GetComponent<Meat>().meatLevel;
                    
                    switch (meat)
                    {
                        case 0:
                            Debug.Log("raw meat");
                            Destroy(hit.collider.gameObject);
                            break;
                        case 1:
                            Debug.Log("cooked meat");
                            Destroy(hit.collider.gameObject);
                            break;
                        case 2:
                            Debug.Log("burnt meat");
                            Destroy(hit.collider.gameObject);
                            break;
                    }
                    var meatManager = GameObject.FindWithTag("Spawner").GetComponent<MeatSpawner>();
                    meatManager.meatCount--;
                    meatManager.RefreshCountText();
                }
            }
        }
    }
}
