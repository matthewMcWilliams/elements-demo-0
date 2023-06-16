using Shinjingi;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class AgentRenderer : MonoBehaviour
{
    [SerializeField] private string runningBoolName = "Running";
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private Move move;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        move = transform.root.GetComponent<Move>();
    }

    private void Update()
    {
        OnMove(move.desiredVelocity);
    }

    public void OnMove(Vector2 targetMovement)
    {
        if (Mathf.Abs(targetMovement.x) < 0.01f)
        {
            animator.SetBool(runningBoolName, false);
            return;
        }
        animator.SetBool(runningBoolName, true);
        spriteRenderer.flipX = targetMovement.x < 0;
    }
}
