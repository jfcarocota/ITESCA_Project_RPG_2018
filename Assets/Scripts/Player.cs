using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character3D
{
    protected override void Jump()
    {
        anim.SetBool("ground", isGrounding);
        if (Btn_jump & isGrounding)
        {
            base.Jump();
            anim.SetTrigger("jump");
        }
    }

    protected override void Move()
    {
        base.Move();
        anim.SetFloat("move", Mathf.Abs(Axis.y));
    }

    protected override void Turn()
    {
        base.Turn();
    }
}
