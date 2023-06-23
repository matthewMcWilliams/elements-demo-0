using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloaterChase : MonoBehaviour
{
    [SerializeField] public Transform chaseThis;
    [SerializeField] private float speed;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnDisable()
    {
        rb.velocity = Vector2.zero;
    }

    private void Update()
    {
        if (chaseThis == null || !enabled)
            return;
        rb.velocity = (chaseThis.position - transform.position) * speed;
    }
}
