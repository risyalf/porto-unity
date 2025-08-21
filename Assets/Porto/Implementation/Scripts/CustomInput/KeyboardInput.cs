using UnityEngine;

namespace Porto.Implementation.Scripts.CustomInput
{
    /// <summary>
    /// Implementasi UserInput.
    /// </summary>
    public class KeyboardInput : UserInput
    {
        #region Mono

        private void Update()
        {
            if (Disable)
            {
                return;
            }

            Value = Vector3.right * Input.GetAxis("Horizontal");
        }

        #endregion
    }
}