using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnDirectionChange : MonoBehaviour
{
    [SerializeField] Axis axis = Axis.X;

    private Rigidbody2D rb;
    internal Vector2 velocity;

    enum Axis { X, Y}

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        velocity = rb.velocity;
    }

    private void FixedUpdate()
    {
        
        switch (axis)
        {
            case Axis.X:
                if (Mathf.Sign(velocity.x) != Mathf.Sign(rb.velocity.x))
                    gameObject.SetActive(false);
                break;
            case Axis.Y:
                if (Mathf.Sign(velocity.y) != Mathf.Sign(rb.velocity.y))
                    Destroy(gameObject);
                break;
        }
        velocity = rb.velocity;
    }
}
