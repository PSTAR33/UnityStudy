using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody enemyRd;
    private float moveRate;
    private float x;
    private float timeAfterMove;
    private float time = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        timeAfterMove += time.deltaTime;
        x = Mathf.Sin(timeAfterMove) * length;

        transform.position = new Vector3(x * speed, transform.position.y, transform.position.z);
        */


        
        this.time += Time.deltaTime;
        
        if (this.time > 3f || this.time < 5f)
        {
            moveRate = Random.Range(-10.0f, 10.0f);
            if (moveRate < 0)
            {
                transform.Translate(Vector3.left * speed);
                print("왼쪽이동");
            }
            if (moveRate > 0)
            {
                transform.Translate(Vector3.right * speed);
                print("오른쪽이동");
            }
            
        }
        if (this.time < 5f)
        {
            this.time = 0.0f;
        }
        


        //enemyRd.AddForce(new Vector3(speed, 0, 0))

        /*
        this.time += Time.deltaTime;
        if (this.time > 0.3f)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (this.time > 0.6f)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        */

    }
}
