using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    public bool inverseGravity = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xForce = Input.GetAxis("Horizontal");
        float yForce = Input.GetAxis("Vertical");
        rb.AddForce(new Vector2(xForce, yForce));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            inverseGravity = !inverseGravity;
        }
    }
}
