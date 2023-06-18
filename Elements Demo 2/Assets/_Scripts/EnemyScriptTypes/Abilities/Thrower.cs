using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrower : Emittor
{
    [SerializeField] public Transform throwAt;
    [SerializeField] float throwSpeed;
    [HideInInspector] new float initialVelocity;
    [SerializeField] float delay;

    private void Start()
    {
        StartCoroutine(ThrowCoroutine());
    }

    private IEnumerator ThrowCoroutine()
    {
        yield return new WaitForSeconds(delay);
        if (throwAt == null || !enabled)
        {
            StartCoroutine(ThrowCoroutine());
        }
        else
        {
            var @object = CreateObject();
            @object.GetComponent<Rigidbody2D>().velocity = (throwAt.position - transform.position).normalized * throwSpeed;
            StartCoroutine(ThrowCoroutine());
        }
    }


}
