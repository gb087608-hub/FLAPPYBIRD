using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flylogic : MonoBehaviour
{
    public float flyForce;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        FLY();
    }

    void FLY()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = Vector2.up * flyForce;
        }
    }
}