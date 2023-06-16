using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsManager : Singleton<EventsManager>
{
    public event System.Action OnPlayerJumpLand;
    public event System.Action OnPlayerChangeDirection;
    public event System.Action OnPlayerMove;

    public void PlayerJumpLand()
    {
        OnPlayerJumpLand?.Invoke();
    }

    public void PlayerChangeDirection()
    {
        OnPlayerChangeDirection?.Invoke();
    }

    public void PlayerMove()
    {
        OnPlayerMove?.Invoke();
    }
}
