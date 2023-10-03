using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_enemy : MonoBehaviour
{
    private GameObject AttackArea = default;

    private float timeToAttack = 3f;
    // private float delay = 0.30f;
    private float timer = 0f;
    public float range = 7f;

    private bool attacking = false;

    private Transform player;
    Rigidbody2D rb;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        AttackArea = transform.GetChild(0).gameObject;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        AttackArea.SetActive(attacking);

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void serang()
    {

        attack();
        // if(attacking)
        // {
        //         timer += Time.deltaTime;

        //         if(timer >= timeToAttack)
        //         {
        //             timer = 0;
        //             delay();
        //         }
        // }
    }

    public void attack()
    {
        attacking = true;
        AttackArea.SetActive(attacking);
    }

    public void delay()
    {
        attacking = false;
        AttackArea.SetActive(attacking);
    }

    public void cooling()
    {
        anim.SetBool("cooling", true);

        timer += Time.deltaTime;

        if(timer >= timeToAttack)
        {
            anim.SetBool("cooling", false);
        }
        
    }
}
