using UnityEngine;

namespace Porto.Implementation.Scripts.CustomInput
{
    /// <summary>
    /// Implementasi UserInput.
    /// </summary>
    public class KeyboardMoveInput : UserInput<Vector3>
    {
        #region UserInput<bool>

        public override string ID { get; protected set; } = "Move Input Keyboard";

        #endregion

        #region Mono

        private void Update()
        {
            if (Disable)
            {
                if (Value.x != 0)
                {
                    Value = Vector3.zero;
                }

                return;
            }

            Value = Vector3.right * Input.GetAxis("Horizontal");
        }

        #endregion
    }
}