using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameCore
{
    namespace SystemControls
    {
        public class SystemControls
        {
            /// <summary>
            /// Regresa el eje del teclado con el que se movera el jugador.
            /// </summary>
            public static Vector2 Axis
            {
                get { return new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")); }
            }

            /// <summary>
            /// Regresa el eje del teclado con el que se movera el jugador con el tiempo delta aplicado.
            /// </summary>
            public static Vector2 AxisDelta
            {
                get { return new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Time.deltaTime; }
            }

            public static bool Btn_jump
            {
                get { return Input.GetButtonDown("Jump"); }
            }
        }
    }
}
