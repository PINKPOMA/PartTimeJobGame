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
            Vector2 mousePos = Camera.main!.ScreenToWorldPoint(Input.mousePosition); //마우스 왼쪽 버튼 클릭 시 현재 마우스의 위치를 월드 좌표로 변환해서 받아옵니다.
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero, 0f); //레이캐스트 선언문 입니다.
            if (hit) //히트 확인을 먼저 해줍니다. 만약 이 확인을 먼저 하지 않았다면 아래 if문에서 nullreferenceexception오류가 생길겁니다.
            {
                if (hit.collider.CompareTag("Meat")) //태그가 Meat일 때만 아래 코드를 실행합니다. Meat태그는 고기에만 달려있습니다. 
                {
                    var meat = hit.transform.gameObject.GetComponent<Meat>().meatLevel; //히트 오브젝트(고기)에 접근하여 Meat 클래스 안에 있는 meatLevel 변수를 받아옵니다. 이 변수는 고기의 익은 정도를 담고 있습니다.
                    
                    switch (meat)
                    {
                        case 0:
                            Debug.Log("raw meat"); // 값이 0 일 때에는 고기가 익지 않은 상태입니다. 점수를 깎거나 hp를 감소시킵니다.
                            Destroy(hit.collider.gameObject);
                            break;
                        case 1:
                            Debug.Log("cooked meat"); // 값이 1 일 때에는 고기가 익은 상태입니다. 점수를 올립니다.
                            Destroy(hit.collider.gameObject);
                            break;
                        case 2:
                            Debug.Log("burnt meat"); // 값이 2 일 때에는 고기가 탄 상태입니다. 점수를 깎거나 hp를 감소시킵니다.
                            Destroy(hit.collider.gameObject);
                            break;
                    }
                    // 위에서 고기를 삭제했으니 여기서 고기 카운트를 줄여줄겁니다.
                    var meatManager = GameObject.FindWithTag("Spawner").GetComponent<MeatSpawner>(); // FindWithTag를 사용하면 해당 Tag가 달려있는 오브젝트만 확인하기에 기본 Find 보다 효율적입니다. 위에서 했던 방법과 똑같이 아래에서 MeatSpawner를 가져왔습니다.
                    meatManager.meatCount--; // meatCount를 하나 줄여줍니다.
                    meatManager.RefreshCountText(); // 해당 함수는 고기 개수를 보여주는 Text를 새로고침 하는 용도로 만들었습니다. 방금 개수를 하나 내렸으니 호출하여 반영시켜줍니다.
                }
            }
        }
    }
}
