using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deltaTime : MonoBehaviour
{
    float speed = 20.0f;

    float startTime;
    float startDeltaTime;

    private void Start()
    {
        startTime = Time.time;
        startDeltaTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        startDeltaTime += Time.deltaTime * 1;
        Debug.Log(t);
    }
}
