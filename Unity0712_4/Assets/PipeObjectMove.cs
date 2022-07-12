using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeObjectMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - 0.03f, transform.position.y, 0);
        if (transform.position.x <= -7.5f)
        {
            Destroy(gameObject);
        }
    }
    /*
    void Update()
    {
        transform.position = new Vector3(transform.position.x - 0.03f, transform.position.y, 0);
        if (transform.position.x <= -7.5f)
        {
            Destroy(gameObject);
        }
    }
    */
}
