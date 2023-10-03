using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public float speed;
    public float lineOfSite;
    public float shootingRange;
    public float fireRate = 1f;
    private float fireTime;
    public GameObject Bullet1;
    // public Transform BulletPos;
    public Transform BulletParent;
    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if(distanceFromPlayer < lineOfSite && distanceFromPlayer > shootingRange)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }

        else if(distanceFromPlayer <= shootingRange && fireTime < Time.time)
        {
           fireTime += Time.deltaTime;

            if(fireTime > 2)
            {
                fireTime = 0;
                shoot();
            }
        }

    }

    void shoot()
    {
        Instantiate(Bullet1, BulletParent.position, Quaternion.identity);
    }
}
