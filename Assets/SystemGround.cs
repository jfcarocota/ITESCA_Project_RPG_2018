using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace GameCore
{
    namespace SystemGround
    {
        [Serializable]
        public class SystemGround
        {
            [SerializeField]
            Color rayColor;
            [SerializeField, Range(0f, 15f)]
            float rayLenght;
            [SerializeField]
            LayerMask groundLayer;
            RaycastHit hit;

            public RaycastHit isGrounding(Transform t)
            {
                Physics.Raycast(t.position, -t.up, out hit, rayLenght, groundLayer);
                return hit;
            }

            public void DrawRay(Transform t)
            {
                Gizmos.color = rayColor;
                Gizmos.DrawRay(t.position, -t.up * rayLenght);
            }
        }
    }
}
