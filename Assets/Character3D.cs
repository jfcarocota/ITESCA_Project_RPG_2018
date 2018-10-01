using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameCore.SystemControls;
using GameCore.SystemGround;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]

public abstract class Character3D : MonoBehaviour
{
    [SerializeField, Range(0f, 10f)]
    float moveSpeed;
    [SerializeField, Range(0, 250)]
    float rotationSpeed;
    [SerializeField, Range(0, 10)]
    float jumpForce;

    protected Animator anim;
    protected Rigidbody rb;

    [SerializeField]
    protected SystemGround sg;

    protected bool ground;

    protected void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    protected virtual void Move()
    {
        transform.Translate(SystemControls.AxisDelta.y * Vector3.forward * moveSpeed);
    }

    protected virtual void Turn()
    {
        transform.Rotate(Vector3.up * rotationSpeed * SystemControls.AxisDelta.x);
    }

    protected virtual void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void FixedUpdate()
    {
        ground = sg.isGrounding(transform).collider;
    }

    private void Update()
    {
        Move();
        Turn();
        Jump();
    }

    private void OnDrawGizmosSelected()
    {
        sg.DrawRay(transform);
    }
}
