using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        SingletonManager.Instance.SetScore(77777);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") == 1)
        {
            // SceneManager.LoadScene(1);
            SceneManager.LoadScene("End");
        }
    }
}
