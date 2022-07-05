using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletController : MonoBehaviour
{
    public float speed = 10.0f;
    GameObject player;
    //private Rigidbody bulletRd;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shoot()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, speed));
    }

    public void ShootToEnemy()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, speed));
    }

    public void ShootToPlayer()
    {
        player = GameObject.Find("Player");

        Vector3 dir = player.transform.position - this.transform.position;
        GetComponent<Rigidbody>().AddForce(dir * speed / 10);
    }

    public void OnCollisionEnter(Collision coll)
    {
        
        if (coll.collider.tag == "ENEMY")
        {
            // UI Ä«¿îÅÍ +1
            GameObject manager = GameObject.Find("ScoreManager");
            manager.GetComponent<ScoreScript>().IncScore();

            // ÃÑ¾Ë ÆÄ±«
            Destroy(gameObject);
        }
        if (coll.collider.tag == "ENEMYRED")
        {
            // UI Ä«¿îÅÍ +5

            GameObject manager1 = GameObject.Find("ScoreManager");
            manager1.GetComponent<ScoreScript>().IncScore(3);

            // ÃÑ¾Ë ÆÄ±«
            Destroy(gameObject);
        }
        if (coll.collider.tag == "ENEMYGREEN")
        {
            // UI Ä«¿îÅÍ +3

            GameObject manager2 = GameObject.Find("ScoreManager");
            manager2.GetComponent<ScoreScript>().IncScore(2);

            // ÃÑ¾Ë ÆÄ±«
            Destroy(gameObject);
        }
        if (coll.collider.tag == "ENEMYBLUE")
        {
            // UI Ä«¿îÅÍ +1

            GameObject manager3 = GameObject.Find("ScoreManager");
            manager3.GetComponent<ScoreScript>().IncScore(1);

            // ÃÑ¾Ë ÆÄ±«
            Destroy(gameObject);
        }
        if (coll.collider.tag == "PLAYER")
        {
            // UI Ä«¿îÅÍ -1

            GameObject manager4 = GameObject.Find("ScoreManager");
            manager4.GetComponent<ScoreScript>().IncScore(-1);

            // ÃÑ¾Ë ÆÄ±«
            Destroy(gameObject);
        }
    }
}
