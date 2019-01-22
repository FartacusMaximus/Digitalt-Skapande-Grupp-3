using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashScript : MonoBehaviour
{
    public int dashSpeed;
    private Rigidbody2D rbody;


    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>(); 
        dashSpeed = 15;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rbody.velocity = new Vector2 (dashSpeed, 0);
        }
    }
}
