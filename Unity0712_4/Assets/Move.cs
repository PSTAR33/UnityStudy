using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(Vector3.right * Time.deltaTime);
        // transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, 0), Time.deltaTime);
        // 둘다 물리엔진 없이 포지션 정보로 위치만 이동되는것
        // gameObject.GetComponent<Rigidbody2D>().MovePosition(transform.position + transform.right * Time.deltaTime);
        
    }
}
