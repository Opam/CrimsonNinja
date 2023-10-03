using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private GameObject AttackArea = default;

    private bool attacking = false;
    public bool button_attack = false;

    private float timeToAttack = 0.40f;
    private float timer = 0f;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        AttackArea = transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)||(button_attack == true))
        {
            attack();
            anim.SetBool("attack_char", true);
        }

        // if(attacking == true)
        // {
            
        // }

        if(attacking)
        {
            

            timer += Time.deltaTime;

            if(timer >= timeToAttack)
            {
                timer = 0;
                attacking = false;
                AttackArea.SetActive(attacking);
                anim.SetBool("attack_char", false);
            }
        }
    }

    public void attack()
    {
        attacking = true;
        AttackArea.SetActive(attacking);
    }

    public void tekan_attack()
    {
        button_attack = true;
    }
    public void lepas_attack()
    {
        button_attack = false;
    }
}
