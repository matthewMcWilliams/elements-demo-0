using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEnter : MonoBehaviour
{
    [SerializeField] LayerMask triggerEnterMask;
    [SerializeField] UnityEvent triggerEnter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (LayerHelper.ColliderIsOnLayer(collision, triggerEnterMask))
        {
            //Debug.Log("ENTER");
            triggerEnter?.Invoke();
        }
    }
}
