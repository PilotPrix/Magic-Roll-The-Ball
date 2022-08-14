using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject winPanel;

    public float gravityMultiplier = 1f;
    public bool inverseGravity = false;

    // Start is called before the first frame update
    void Start()
    {
        rb.gravityScale = gravityMultiplier;
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
    // When the player falls in the basket, say you win, move to next level
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        if (collision.gameObject.name == "Hat Collider")
        {
            winPanel.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
