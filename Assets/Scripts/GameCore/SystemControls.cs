﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameCore
{
    namespace SystemControls
    {
        public class Controls
        {
            public static Vector2 Axis
            {
                get
                {
                    return new Vector2( Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
                }
            }

            public static Vector2 AxisDeltaTime
            {
                get
                {
                    return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Time.deltaTime;
                }
            }

            public static bool Btn_jump
            {
                get
                {
                    return Input.GetButtonDown("Jump");
                }
            }

            public static void MoveFwd(Transform t, float speed)
            {
                t.Translate(Vector3.forward * speed * AxisDeltaTime.y);
            }

            public static void RotUp(Transform t, float speed)
            {
                t.Rotate(t.up * speed * AxisDeltaTime.x);
            }

            public static void Jump(Rigidbody rb, float jumpForce)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}
