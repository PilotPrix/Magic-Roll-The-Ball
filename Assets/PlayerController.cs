using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    public float gravityMultiplier = 1f;
    public bool inverseGravity = false;

    // Start is called before the first frame update
    void Start()
    {
        rb.gravityScale = gravityMultiplier;
        Debug.Log("Hello");
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
            if (inverseGravity) rb.gravityScale = -gravityMultiplier;
            else rb.gravityScale = gravityMultiplier;
        }
    }
}
