using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class HpController : MonoBehaviour
{
    GameObject robot;
    GameObject hp;    
    private float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        hp = GameObject.Find("HpImage");        
        robot = GameObject.Find("Robot");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HpControl()
    {
        hp.GetComponent<Image>().fillAmount -= 0.5f;

        if(hp.GetComponent<Image>().fillAmount <= 0)
        {
            this.time += Time.deltaTime;

            if (this.time < 3f)
            {
                print("3초");
                // Death 애니 실행
                robot.GetComponent<Animator>().SetTrigger("deathTrigger");
                this.time += 5f;
            }

            if (this.time > 7f)
            {
                print("4초");
                // 씬 전환
                SceneManager.LoadScene("GameOverScene");
            }
            
            

        }

    }
}
