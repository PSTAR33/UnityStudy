using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator2 : MonoBehaviour
{
    public GameObject bulletPrefab;
    private float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.time += Time.deltaTime;

        if(this.time > 0.1f)
        {
            Shoot();
            this.time = 0.0f;
            
        }

        /*
        if(Input.GetMouseButtonDown(0))  // 0�� ���� 1�� ������
        {
            // �������� �̿��ؼ� ������Ʈ(�Ѿ�) ����
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            // BulletController���� Shoot �޼��� ȣ��(�Ѿ� �߻�)
            bullet.GetComponent<BulletController>().ShootToPlayer();
        }
        */
    }

    public void Shoot()
    {
        // �������� �̿��ؼ� ������Ʈ(�Ѿ�) ����
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

        // BulletController���� Shoot �޼��� ȣ��(�Ѿ� �߻�)
        bullet.GetComponent<BulletController>().ShootToPlayer();

    }
}
