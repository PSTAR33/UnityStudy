using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankController : MonoBehaviour
{
    float mvSpeed = 10.0f;
    float roSpeed = 150.0f;
    private Text score1;
    private Text score2;

    public int playerNum = 1; // 탱크 번호
    private string mvAxisName; // 이동축 이름(Vertical1, Vertical2)
    private string roAxisName; // 회전축 이름(Horizontal1, Horizontal2)

    public ParticleSystem tankExplosion;

    // Start is called before the first frame update
    void Start()
    {
        mvAxisName = "Vertical" + playerNum;
        roAxisName = "Horizontal" + playerNum;
    }

    // Update is called once per frame
    void Update()
    {
        float mv = Input.GetAxis(mvAxisName) * mvSpeed * Time.deltaTime;
        float ro = Input.GetAxis(roAxisName) * roSpeed * Time.deltaTime;

        transform.Translate(0, 0, mv);
        transform.Rotate(0, ro, 0);

    }

    public void OnCollisionEnter(Collision coll)
    {

        this.score1 = GameObject.Find("Score2").GetComponent<Text>();
        this.score2 = GameObject.Find("Score1").GetComponent<Text>();
        

        if (coll.collider.tag == "SHELL")
        {
            if (score1.text == "3")
            {
                ParticleSystem fire = Instantiate(tankExplosion, transform.position, transform.rotation);
                fire.Play(); // 이펙트 재생

                Destroy(gameObject);
                Destroy(fire.gameObject, 2.0f);
            }
            if (score2.text == "3")
            {
                ParticleSystem fire = Instantiate(tankExplosion, transform.position, transform.rotation);
                fire.Play(); // 이펙트 재생

                Destroy(gameObject);
                Destroy(fire.gameObject, 2.0f);
            }
        }
    }

}