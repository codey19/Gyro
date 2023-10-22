using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healt : MonoBehaviour
{
    public Image healthBar;
    public float health = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) {
            TakeDamage(1);
        }
    }

    public void TakeDamage(float damage) {
        health -= damage;
        healthBar.fillAmount = health / 3f;
    }
}
