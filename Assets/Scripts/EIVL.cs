using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EIVL : MonoBehaviour
{
    public GameObject gyro;
    Animator ani;
    Rigidbody2D rb;
    public int health;
    public bool here;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        health = 3;
        here = false;
        timer = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (!here) {
            ani.SetBool("walk", true);
            if (gyro.transform.position.x < transform.position.x)
            {
                transform.Translate(Vector2.left * Time.deltaTime);
                transform.localScale = new Vector2(1, 1);
            }
            else {
                transform.Translate(Vector2.right * Time.deltaTime);
                transform.localScale = new Vector2(-1, 1);
            }
            if (gyro.transform.position.y < transform.position.y)
            {
                transform.Translate(Vector2.down * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector2.up * Time.deltaTime);
            }
        }
        else {
            timer += Time.deltaTime;
            ani.SetBool("walk", false);
            if (timer > 1)
            {
                ani.SetTrigger("attack");
                timer = 0;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if (collision.gameObject.tag == "Sward")
        {
            if (health == 0)
                ani.SetTrigger("death");
            else
            {
                ani.SetTrigger("hit");
                health--;
            }
        }*/
        if (collision.gameObject.tag == "Archer") {
            here = true;
            Debug.Log("here");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Archer")
        {
            here = false;
            Debug.Log("left");

        }
    }
}
