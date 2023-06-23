using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierCurve : MonoBehaviour
{
    public Vector2[] points;

    public Vector3 GetPoint(float t) => transform.TransformPoint(Bezier.GetPoint(points[0], points[1], points[2], points[3], t));

    public Vector3 GetVelocity(float t) => transform.TransformPoint(Bezier.GetFirstDerivative(points[0], points[1], points[2], points[3], t)) -
            transform.position;

    public Vector3 GetDirection(float t) => GetVelocity(t).normalized;

    public void Reset()
    {
        points = new Vector2[]{
            new Vector2(1f, 0f),
            new Vector2(2f, 0f),
            new Vector2(3f, 0f),
            new Vector2(4f, 0f)
        };
    }
}
