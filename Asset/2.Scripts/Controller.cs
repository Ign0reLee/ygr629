using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Controller : MonoBehaviour
{
    private GameObject target;

 

  
    void FixedUpdate()
    {

        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
            if (target == GameObject.FindGameObjectWithTag("Coma"))
            {
                //캐릭터 표시 전환
                //캐릭터 이동 버튼
                //마을클릭 및 좌표값 전달
            }
        }
    }
    void CastRay()
    {
        target = null;

        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

        if(hit.collider != null)
        {
            Debug.Log(hit.collider.name);
            target = hit.collider.gameObject;
        }
    }

}
