using Porto.Core.Scripts;
using UnityEngine;

namespace Porto.Implementation.Scripts.CustomInput
{
    /// <summary>
    /// Implementasi IInput dengan value Vector3.
    /// </summary>
    public class UserInput : MonoBehaviour, IInput<Vector3>
    {
        #region Variables

        /// <summary>
        /// Trigger disable atau bukan.
        /// </summary>
        protected bool Disable = false; 
    
        #endregion
        
        #region IInput<Vector3>

        public Vector3 Value { get; protected set; } = Vector3.zero;

        public void SetDisable(bool disable)
        {
            Disable = disable;
        }

        #endregion
    }
}