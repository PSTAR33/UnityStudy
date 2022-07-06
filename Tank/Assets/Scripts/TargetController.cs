using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public ParticleSystem tankExplosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == "SHELL")
        {
            ParticleSystem fire = Instantiate(tankExplosion, transform.position, transform.rotation);
            fire.Play(); // ÀÌÆåÆ® Àç»ý

            Destroy(gameObject);
            Destroy(fire.gameObject, 2.0f);
        }
    }
}
