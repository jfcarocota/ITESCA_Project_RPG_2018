using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameCore.SystemControls;
using GameCore.SystemGround;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(Rigidbody))]

public abstract class Character3D : MonoBehaviour
{
    [SerializeField, Range(0, 10)]
    protected float moveSpeed;
    [SerializeField, Range(0, 180)]
    protected float rotationSpeed;
    [SerializeField, Range(0, 15)]
    protected float jumpForce;

    protected Animator anim;
    protected Rigidbody rb;

    [SerializeField]
    Ground ground;

    protected bool isGrounding;

    void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
        Jump();
        Turn();

        isGrounding = ground.isGrounding(transform);
    }

    protected virtual void Move()
    {
        Controls.MoveFwd(transform, moveSpeed);
    }
    protected virtual void Jump()
    {
        Controls.Jump(rb, jumpForce);
    }
    protected virtual void Turn()
    {
        Controls.RotUp(transform, rotationSpeed);
    }

    protected bool Btn_jump
    {
        get
        {
            return Controls.Btn_jump;
        }
    }

    protected Vector2 Axis
    {
        get
        {
            return Controls.Axis;
        }
    }

    private void OnDrawGizmosSelected()
    {
        ground.DrawRay(transform);
    }
}
