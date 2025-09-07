using System;
using Porto.Core.Scripts;
using UnityEngine;

namespace Porto.Implementation.Scripts.Target
{
    /// <summary>
    /// Implementasi ITarget<T>
    /// </summary>
    /// <typeparam name="T">
    /// Jenis target.
    /// </typeparam>
    public abstract class BaseTarget<T> : MonoBehaviour, ITarget<T>
    {
        #region Variables

        [SerializeField]
        private string id = string.Empty;

        #endregion

        #region ITarget<Transform>

        public string ID => id;

        public T CurrentTarget { get; protected set; }

        public abstract void ChangeTarget(T newTarget);

        public Action<string> OnChangeTarget { get; set; } = null;

        #endregion
    }
}