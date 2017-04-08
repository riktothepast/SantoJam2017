using UnityEngine;

public class Planet : MonoBehaviour {

    public Rigidbody2D rigidBody2D;
    public CircleCollider2D circleCollider2D;
    public float radius;
    public float mass;

    public void Awake()
    {
        rigidBody2D = gameObject.AddComponent<Rigidbody2D>();
        circleCollider2D = gameObject.AddComponent<CircleCollider2D>();
        rigidBody2D.mass = mass;
        circleCollider2D.radius = radius;
        rigidBody2D.gravityScale = 0;
        rigidBody2D.bodyType = RigidbodyType2D.Kinematic;
    }

}
