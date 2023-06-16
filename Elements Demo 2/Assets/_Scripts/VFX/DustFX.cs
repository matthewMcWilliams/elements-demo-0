using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustFX : MonoBehaviour
{
    [SerializeField] private ParticleSystem dust;
    [SerializeField] private bool dustOnJumpOrLand, dustOnMove, dustOnChangeDirection;

    private void Start()
    {
        if (dustOnJumpOrLand)
            EventsManager.Instance.OnPlayerJumpLand += CreateDust;
        if (dustOnMove)
            EventsManager.Instance.OnPlayerMove += CreateDust;
        if (dustOnChangeDirection)
            EventsManager.Instance.OnPlayerChangeDirection += CreateDust;
    }

    public void CreateDust()
    {
        dust.Play();
    }
}
