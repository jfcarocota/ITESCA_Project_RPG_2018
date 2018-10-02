using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace GameCore
{
    namespace SystemGround
    {
        [Serializable]
        public class Ground
        {
            [SerializeField]
            Color rayColor = Color.cyan;
            [SerializeField, Range(0f, 10f)]
            float rayDistance;
            [SerializeField]
            LayerMask groundLayer;

            RaycastHit hit;

            public RaycastHit Hit
            {
                get
                {
                    return hit;
                }
            }

            public void DrawRay(Transform t)
            {
                Gizmos.color = rayColor;
                Gizmos.DrawRay(t.position, -t.up * rayDistance);
            }

            public bool isGrounding(Transform t)
            {
                return Physics.Raycast(t.position,  -t.up, out hit, rayDistance, groundLayer);                
            }
        }
    }
}
