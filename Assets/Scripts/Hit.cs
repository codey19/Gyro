using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public GameObject gyro;
    anim a;
    public GameObject badGyro;
    EIVL evil;
    public healt health;
    // Start is called before the first frame update
    void Start()
    {

        a = gyro.GetComponent<anim>();
        evil = badGyro.GetComponent<EIVL>();

    }
        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0) && evil.here)
            {
                health.TakeDamage(1);
            }   
        }
}
