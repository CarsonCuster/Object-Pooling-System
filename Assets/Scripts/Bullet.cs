using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void OnEnable()
    {
        rb.AddForce(transform.up * 10.0f, ForceMode2D.Impulse);
    }
}
