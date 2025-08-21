using Porto.Core.Scripts;
using UnityEngine;

namespace Porto.Implementation.Scripts.Camera
{
    /// <summary>
    /// Menangani perpindahan camera.
    /// </summary>
    public class CameraFollow : MonoBehaviour
    {
        #region Variables

        /// <summary>
        /// Target dari camera.
        /// </summary>
        private ITarget<GameObject> _target = null;

        #endregion
    }
}
