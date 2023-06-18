using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private Vector2 startPos;
    public GameObject cam;
    public float parallaxEffectX;
    public float parallaxEffectY;
    public float length;


    // Start is called before the first frame update
    void Start()
    {
        startPos = new Vector2((transform.position - cam.transform.position * parallaxEffectX - (transform.position-cam.transform.position)*parallaxEffectX).x, (transform.position - cam.transform.position * parallaxEffectY).y);
        length = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        float distX = (cam.transform.position.x * parallaxEffectX);
        float distY = cam.transform.position.y * parallaxEffectY;

        transform.position = new Vector3(startPos.x + distX, startPos.y + distY, transform.position.z);

        
    }
}
