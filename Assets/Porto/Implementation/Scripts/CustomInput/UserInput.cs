using Porto.Core.Scripts;
using UnityEngine;

namespace Porto.Implementation.Scripts.CustomInput
{
    /// <summary>
    /// Implementasi IInput dengan value Vector3.
    /// </summary>
    public class UserInput<T> : MonoBehaviour, IInput<T>
    {
        #region Variables

        /// <summary>
        /// Trigger disable atau bukan.
        /// </summary>
        protected bool Disable = false;

        #endregion

        #region IInput<Vector3>

        public virtual string ID { get; protected set; } = string.Empty;

        public T Value { get; protected set; }

        public void SetDisable(bool disable)
        {
            Disable = disable;
        }

        #endregion
    }
}