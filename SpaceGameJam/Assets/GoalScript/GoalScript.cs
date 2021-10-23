using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalScript : MonoBehaviour
{
    public BoxCollider2D collider;
    public Transform[] spawnPoints;
    public AudioSource levelCompleteSound;
    public Text distanceText;
    public GameObject playerShip;
    public GameObject[] astroids;
    // Start is called before the first frame update
    void Start()
    {
        collider = this.gameObject.GetComponent<BoxCollider2D>();
        astroids = GameObject.FindGameObjectsWithTag("Astroid");
    }

    // Update is called once per frame
    void Update()
    {
        distanceText.text = ((int)Vector3.Distance(this.transform.position, playerShip.transform.position)).ToString();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Spaceship")
        {
            Debug.LogError("HIT");
            this.transform.position = spawnPoints[Random.Range(0, 4)].position;
            other.gameObject.transform.position = spawnPoints[Random.Range(0, 4)].position;
            levelCompleteSound.Play();
            foreach (GameObject gameObject in astroids)
            {
                gameObject.GetComponent<AstroidInitialPush>().ResetPosition();
            }
        }
    }
}
