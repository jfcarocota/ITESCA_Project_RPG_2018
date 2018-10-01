using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameCore.SystemControls;

public class Player : Character3D
{
    protected override void Jump()
    {
        anim.SetBool("ground", ground);
        if (ground & SystemControls.Btn_jump)
        {
            base.Jump();
            anim.SetTrigger("jump");
        }
    }

    protected override void Move()
    {
        base.Move();
        anim.SetFloat("move", Mathf.Abs(SystemControls.AxisDelta.y));
    }

}
