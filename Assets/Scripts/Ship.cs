using System.Collections;
using UnityEngine;

public class Ship : MonoBehaviour {

    PlanetManager planetManager;
    Rigidbody2D rigidBody2D;
    public float maxGravDist = 2.0f;
    public float maxGravity = 5.0f;

    void Awake () {
        planetManager = FindObjectOfType<PlanetManager>();
        rigidBody2D = GetComponent<Rigidbody2D>();
    }
	
	void FixedUpdate () {
        foreach (Planet planet in planetManager.planets)
        {
            // gravitational universal law
            float dist = Vector3.Distance(planet.transform.position, transform.position);
            Vector3 delta = planet.transform.position - transform.position;
            float radius = Mathf.Abs(Vector2.Distance(planet.transform.position, transform.position));
            float force = -UnityEngine.Physics2D.gravity.y * ((rigidBody2D.mass * planet.mass) / (radius * radius));
            rigidBody2D.AddForce(delta.normalized * force);
        }
    }
}
