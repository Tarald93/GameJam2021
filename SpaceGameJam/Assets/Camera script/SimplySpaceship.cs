using UnityEngine;
using System.Collections;

public class SimplySpaceship : MonoBehaviour {

	float speed = 5f;
	public float maxMovementDistance = 25f;
	private Transform transform;

    private void Start()
    {
		transform = this.gameObject.transform;
    }

    void Update () 
	{
        float horizontalMovement = GetHorizontalMovement();
        float verticalMovement = GetVerticalMovement();
		transform.Translate(new Vector3(horizontalMovement, verticalMovement, 0) * Time.deltaTime );
	}

	public float GetHorizontalMovement()
    {
        Vector3 tempTransform = new Vector3(transform.position.x, 0, 0);
        tempTransform += new Vector3(Input.GetAxis("Horizontal") * speed, 0, 0) * Time.deltaTime;


        if (tempTransform.x > maxMovementDistance || tempTransform.x < -maxMovementDistance)
        {
            return 0;
        }

        return Input.GetAxis("Horizontal") * speed;
    }

    public float GetVerticalMovement()
    {
        Vector3 tempTransform = new Vector3(0, transform.position.y, 0);
        tempTransform += new Vector3(0, Input.GetAxis("Vertical") * speed, 0) * Time.deltaTime;

        if (tempTransform.y > maxMovementDistance || tempTransform.y < -maxMovementDistance)
        {
            return 0;
        }

        return Input.GetAxis("Vertical") * speed;
    }
}
