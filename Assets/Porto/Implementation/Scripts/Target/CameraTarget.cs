using Unity.Cinemachine;
using UnityEngine;

namespace Porto.Implementation.Scripts.Target
{
    /// <summary>
    /// Implementasi ITarget dengan jenis camera.
    /// </summary>
    public class CameraTarget : BaseTarget<GameObject>
    {
        #region Variables

        /// <summary>
        /// Camera cinemachine.
        /// </summary>
        private CinemachineCamera _camera = null;

        #endregion

        #region BaseTarget<string>

        public override void ChangeTarget(GameObject newTarget)
        {
            CurrentTarget = newTarget;

            _camera.LookAt = newTarget.transform;
            _camera.Follow = newTarget.transform;

            OnChangeTarget?.Invoke(newTarget.name);
        }

        #endregion

        #region Mono

        private void Awake()
        {
            _camera = GetComponent<CinemachineCamera>();
        }

        #endregion
    }
}
