using System;
using System.Linq;
using Porto.Core.Scripts;
using UnityEngine;

namespace Porto.Implementation.Scripts.Movement
{
    /// <summary>
    /// Implementasi IMove.
    /// </summary>
    public class PlayerMovement : MonoBehaviour, IMove
    {
        #region Variables

        /// <summary>
        /// Input yang diberikan oleh user.
        /// </summary>
        private IInput<Vector3> _input = null;
        
        /// <summary>
        /// Kecepatan yang dimiliki oleh object.
        /// </summary>
        private ISpeed _speed = null;
        
        #endregion
        
        #region IMove

        public void DoMove()
        {
            transform.Translate(_input.Value * _speed.Value * Time.deltaTime, Space.World);
        }

        #endregion

        #region Mono

        private void Awake()
        {
            _input = FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.None).OfType<IInput<Vector3>>()
                .FirstOrDefault();
            
            _speed = FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.None).OfType<ISpeed>()
                .FirstOrDefault();
        }

        private void FixedUpdate()
        {
            DoMove();
        }

        #endregion
    }
}