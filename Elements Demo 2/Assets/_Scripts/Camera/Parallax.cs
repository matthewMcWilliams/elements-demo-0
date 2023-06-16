using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private Vector2 startPos;
    public GameObject cam;
    public float parallaxEffectX;
    public float parallaxEffectY;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position - cam.transform.position * parallaxEffectY;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distX = (cam.transform.position.x * parallaxEffectX);
        float distY = cam.transform.position.y * parallaxEffectY;

        transform.position = new Vector3(startPos.x + distX, startPos.y + distY, transform.position.z);
    }
}
