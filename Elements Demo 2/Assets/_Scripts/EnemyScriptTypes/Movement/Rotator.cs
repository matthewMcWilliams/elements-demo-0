using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform axle;


    private void Awake()
    {
        if (axle == null)
            axle = transform;
    }

    private void Update()
    {
        transform.RotateAround(axle.position, Vector3.forward, speed * Time.deltaTime);
    }
}
