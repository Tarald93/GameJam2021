using UnityEngine;
using System.Collections;

public class SimplySpaceship : MonoBehaviour {

	float speed = 5f;

	void Update () {
		transform.Translate( new Vector3(
			Input.GetAxis("Horizontal") * speed,
			Input.GetAxis("Vertical") * speed,
			0) * Time.deltaTime );
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<Rigidbody2D>().AddForce((transform.position - other.transform.position).normalized * 1500);
        Debug.Log("collision");
        //foreach (ContactPoint contact in collision.contacts)
        //{
        //    Debug.DrawRay(contact.point, contact.normal, Color.white);
        //}
        //if (collision.relativeVelocity.magnitude > 2)
        //    audioSource.Play();
    }
}
