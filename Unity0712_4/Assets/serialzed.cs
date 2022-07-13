using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Man
{
    public string name;
    public int age;
}

public class serialzed : MonoBehaviour
{
    public Man man;

    DontDestroyOnLoad

    [HideInInspector]
    public float speed = 5.0f;

    [SerializeField]
    private float timestemp = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
