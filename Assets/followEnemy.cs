using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followEnemy : MonoBehaviour
{
    public Transform enemy;
    RectTransform recttransform;

    private void Awake()
    {
        recttransform = GetComponent<RectTransform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enemy != null)
        {
            recttransform.anchoredPosition = enemy.localPosition;
        }
    }
}
