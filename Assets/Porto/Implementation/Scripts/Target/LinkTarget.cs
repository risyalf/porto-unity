using System;
using Porto.Core.Scripts;
using UnityEngine;

namespace Porto.Implementation.Scripts.Target
{
    /// <summary>
    /// Implementasi ITarget dengan jenis string.
    /// </summary>
    public class LinkTarget : BaseTarget<string>
    {
        #region BaseTarget<string>

        public override void ChangeTarget(string newTarget)
        {
            CurrentTarget = newTarget;

            OnChangeTarget?.Invoke(newTarget);
        }

        #endregion
    }
}