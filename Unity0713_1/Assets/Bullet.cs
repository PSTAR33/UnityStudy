using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 direction;
    public void Shoot(Vector3 direction)
    {
        this.direction = direction;
        // Destroy(gameObject, 5.0f);
        Invoke("ReturnBulletToPolling", 5.0f);
    }

    public void ReturnBulletToPolling()
    {
        ObjectPool.ReturnObject(this);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction);
    }
}
