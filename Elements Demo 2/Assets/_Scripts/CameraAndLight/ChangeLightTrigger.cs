using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class ChangeLightTrigger : MonoBehaviour
{
    [SerializeField] LayerMask playerMask;
    [SerializeField] new Light2D light;
    [SerializeField, ColorUsage(false, true)] Color color;
    [SerializeField] float intensity;
    [SerializeField] private float length = 1f;

    private float time = 0f, startIntensity;
    private Color startColor;
    private bool moving = false;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!LayerHelper.ColliderIsOnLayer(collision, playerMask))
            return;
        moving = true;
        startIntensity = light.intensity;
        startColor = light.color;
        Debug.Log(light.gameObject.name);
    }

    private void Update()
    {

        if ( moving)
        {
            light.intensity = Mathf.Lerp(startIntensity, intensity, time / length);
            light.color = Color.Lerp(startColor, color, time / length);
            time += Time.deltaTime;
        }
        if (time <= length)
            return;
        moving = false;
        time = 0;
        light.intensity = intensity;
        light.color = color;
    }
}
