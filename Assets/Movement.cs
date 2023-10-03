using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public int kecepatan;
    public int kekuatanLompat;
    public bool balik;
    public int pindah;
    public Rigidbody2D lompat;
    public float jumpAmount = 10;

    public bool tanah;
    public LayerMask targetLayer;
    public Transform deteksitanah;
    public float jangkauan;

    // public int maxHealth = 10;
    // public int currentHealth;

    // public Health_bar healthbar;

    public bool button_kiri = false;
    public bool button_kanan = false;
    public bool button_lompat = false;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        lompat = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
        // currentHealth = maxHealth;
        // healthbar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //deteksi tanah
        tanah = Physics2D.OverlapCircle(deteksitanah.position, jangkauan, targetLayer);
        if(tanah == true)
        {
            anim.SetBool("jump_char", false);
        }
        else
        {
            anim.SetBool("jump_char", true);
        }

        //movement
        if(Input.GetKey(KeyCode.D)||(button_kanan == true))
        {
            transform.Translate(Vector2.right * kecepatan * Time.deltaTime);
            pindah = -1;
            anim.SetBool("run_char", true);
        }
        else if(Input.GetKey(KeyCode.A)||(button_kiri == true))
        {
            transform.Translate(Vector2.right * -kecepatan * Time.deltaTime);
            pindah = 1;
            anim.SetBool("run_char", true);
        }
        else
        {
            anim.SetBool("run_char", false);
        }

        //lompat
        if(tanah == true && (Input.GetKey(KeyCode.W)||(button_lompat == true)))
        {
            lompat.AddForce(Vector2.up * kekuatanLompat, ForceMode2D.Impulse);

            // lompat.velocity = new Vector2(0, lompat.velocity.y);
        }

        //balik karakter
        if(pindah > 0 && !balik)
        {
            flip();
        }
        else if(pindah < 0 && balik)
        {
            flip();
        }
    }

    void flip(){
        balik = !balik;
        Vector3 Player = transform.localScale;
        Player.x *=-1;
        transform.localScale = Player;
    }

    // public void takeDamage (int damage)
    // {
    //     currentHealth -= damage;
    //     healthbar.SetHealth(currentHealth);
    // }

    public void tekan_kiri()
    {
        button_kiri = true;
    }
    public void lepas_kiri()
    {
        button_kiri = false;
    }

    public void tekan_kanan()
    {
        button_kanan = true;
    }
    public void lepas_kanan()
    {
        button_kanan = false;
    }

    public void tekan_lompat()
    {
        button_lompat = true;
    }
    public void lepas_lompat()
    {
        button_lompat = false;
    }
}
