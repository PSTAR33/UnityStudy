using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        print("충돌발생 Enter : "+ collision.gameObject.name);

    }

    public void OnCollisionExit(Collision collision)
    {
        print("충돌발생 Exit!");
    }

}
