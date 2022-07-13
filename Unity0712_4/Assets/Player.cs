using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * 200);
        
        // transform.Translate();
        // Vector3.MoveTowards();
        
        // 좌표 이동의 방법
        // 유니티 시스템에서 호출되는 이벤트의 처리 과정에 대해 설명
        // 멀티쓰레드
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        // 직접 충돌을 원하지 않을시 트리거 사용
        // tag를 쓰지 않고 충돌처리 방법
        if (col.tag == "score")
        {
            // 점수 +1
            //GameObject.FindObjectOfType<GameManager>().Score++;
            //Destroy(col.gameObject);

            Debug.Log("부딛힘_트리거");
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        // 직접 충돌을 원할시 콜리젼 사용
        if(col.collider.tag == "score")
        {
            Debug.Log("부딛힘_콜리젼");
        }
    }
}
