using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidInitialPush : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        rb.angularVelocity = Random.Range(5f, 20f);
        rb.AddForce(new Vector2(Random.Range(100f, 500f), Random.Range(100f, 500f)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
