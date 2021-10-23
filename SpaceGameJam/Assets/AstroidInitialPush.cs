using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidInitialPush : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        rb.angularVelocity = Random.Range(5f, 20f);
        rb.AddForce(new Vector2(Random.Range(100f, 500f), Random.Range(100f, 500f)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetPosition()
    {
        this.transform.position = new Vector3(startPosition.x, startPosition.y, startPosition.z);
        rb.angularVelocity = Random.Range(5f, 20f);
        rb.AddForce(new Vector2(Random.Range(100f, 500f), Random.Range(100f, 500f)));
    }
}
