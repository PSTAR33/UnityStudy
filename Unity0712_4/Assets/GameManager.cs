using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public GameObject objects;
    public TextMesh scoreText;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObjects", 1, 2);
        // StartCoroutine(Mycoroutine(5));
        // StartCoroutine("MyCoroutine");
        
    }

    public int Score
    {
        set
        {
            score = value;
            scoreText.text = Score.ToString();
        }
        get
        {
            return score;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Mycoroutine(int num)
    {
        


        // yield return null;
        // yield return new WaitForSecondsRealtime(2.0f); //실제 시간

        // yield return new WaitForFixedUpdate();

        while (true)
        {
            yield return new WaitForSeconds(1.0f);   // 게임시간
            Instantiate(objects, new Vector3(7.5f, Random.Range(-2f, 2.1f), 0), Quaternion.identity);
        }
        
    }

    void CreateObjects()
    {
        Instantiate(objects, new Vector3(7.5f, Random.Range(-2f, 2.1f), 0), Quaternion.identity);
    }
}
