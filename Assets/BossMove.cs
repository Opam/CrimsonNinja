using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    private GameObject AttackArea = default;

    public float speed;
    public float lineOfSite;
    public float area;

    private bool attacking = false;

    private float timeToAttack = 5f;
    private float timer = 0f;

    Animator anim;
    
    // public Transform BulletPos;
    
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
        if(distanceFromPlayer < lineOfSite )
        {
            anim.SetBool("Walk", true);
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }

        else if(distanceFromPlayer <= area && timer < timeToAttack)
        {
            timer += Time.deltaTime;

            attack();
            // anim.SetBool("Attack", true);

             if(attacking)
            {
    
                if(timer >= timeToAttack)
                {
                    timer = 0;
                    attacking = false;
                    AttackArea.SetActive(attacking);
                    anim.SetBool("Attack", false);
                }
            }
           
        }

    }

    public void attack()
    {
        attacking = true;
        AttackArea.SetActive(attacking);
    }
}
