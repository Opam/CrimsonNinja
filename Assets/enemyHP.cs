using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyHP : MonoBehaviour
{
    public Slider Slider;

    // public Transform player;
    // public float range = 15;
    // public bool isActive = true;
    // public Vector3 Offset;
    
    public void SetMaxHealth(int health)
    {
        Slider.maxValue = health;
        Slider.value = health;
    }

    public void SetHealth(int health)
    {
        Slider.value = health;
    }

    // public void SetHealth(int health, int maxHealth)
    // {
    //     Slider.gameObject.SetActive(health <= maxHealth);
    //     Slider.value = health;
    //     Slider.maxValue = maxHealth;
    // }
    void Start()
    {
        // player = GameObject.FindGameObjectWithTag("Player").transform;
        Slider.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        // float distanceFromPlayer = Vector2.Distance(player.position, transform.position);

        // Slider.gameObject.SetActive(isActive);

        // if(distanceFromPlayer <= range)
        // {
        //     isActive = true;
        //     Slider.gameObject.SetActive(isActive);
        // }
        // else
        // {
        //     isActive = false;
        //     Slider.gameObject.SetActive(isActive);
        // }
        // Slider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position);
    }
}
