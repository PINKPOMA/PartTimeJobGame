using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PotatoGameFlase : MonoBehaviour
{
    //https://m.blog.naver.com/PostView.naver?isHttpsRedirect=true&blogId=ateliersera&logNo=220439790504
   
    //감자의 갯수를 올려주는 버튼은 이 스크립트가 있는 오브젝트입니다.
    private GameObject potatoUpB;



    public GameObject potatoGame;
    public int PotatoHave;

    public void FixedUpdate() 
    {
        {
            
                //감자게임이 꺼져있을때 마우스 버튼으로 오브젝트를 클릭하면
                //스케일이 작아지고, 감자의 갯수가 올라갑니다.
                if(Input.GetMouseButtonDown(0))
                {
                    CastRay();
                    if(potatoUpB == this.gameObject)
                    {       
                        PotatoHave++;
                        transform.localScale = new Vector3(0.3f,0.3f);
                    /*var potatoUp = GameObject.Find("Player").GetComponent("player");
                    potatoUp.P_Potato();
                    https://support.unity.com/hc/en-us/articles/206193836-What-is-CS1061-
                    Player potatoUp = GameObject.Find("Player");*/   

                    }
                }
                else if(Input.GetMouseButtonUp(0))
                {
                    StartCoroutine("Delay");
                }
            
        }
    }

    IEnumerator Delay()
    {
        transform.localScale = new Vector3(0.5f,0.5f);
        yield return new WaitForSeconds(0.5f);
        this.gameObject.SetActive(false);
    }
    void CastRay()
    {
        potatoUpB = null;
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos,Vector2.zero,0f);

        //히트가 되었다면
        if(hit.collider != null)
        {
            potatoUpB = hit.collider.gameObject;
            //히트 된 게임 오브젝트를 타겟으로 지정.
        }
    }


}
