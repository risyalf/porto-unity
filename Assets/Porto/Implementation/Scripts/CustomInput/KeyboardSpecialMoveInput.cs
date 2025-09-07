using Porto.Implementation.Scripts.CustomInput;
using UnityEngine;

namespace Assets.Porto.Implementation.Scripts.CustomInput
{
    /// <summary>
    /// Implementasi UserInput dengan variable bool.
    /// </summary>
    public class KeyboardSpecialMoveInput : UserInput<bool>
    {
        #region UserInput<bool>

        public override string ID { get; protected set; } = "Special Move Input Keyboard";

        #endregion

        #region Mono

        private void Update()
        {
            if (Disable)
            {
                return;
            }

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Value = true;
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                Value = false;
            }
        }

        #endregion
    }
}