using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    Rigidbody2D rb;
    Animator ani;
    int health;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        rb.freezeRotation = true;
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            ani.SetTrigger("attack");
           // arrow = Instantiate(arrowPrefab, arrowPrefab.transform);
                //arrowPrefab.transform.position, arrowPrefab.transform.rotation);

        }
        if (Input.GetKey(KeyCode.W))
        {
            ani.SetBool("walk", true);
            transform.Translate(5 * Vector2.up * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            ani.SetBool("walk", true);
            transform.Translate(5 * Vector2.left * Time.deltaTime);
            transform.localScale = new Vector2(1, 1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            ani.SetBool("walk", true);
            transform.Translate(5 * Vector2.down * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            ani.SetBool("walk", true);
            transform.Translate(5 * Vector2.right * Time.deltaTime);
            transform.localScale = new Vector2(-1, 1);
        }
        else {
            ani.SetBool("walk", false);
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
        if (collision.gameObject.tag == "Sward") {
            ani.SetTrigger("hit");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {

    }
}
