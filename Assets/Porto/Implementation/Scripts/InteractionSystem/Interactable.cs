using Assets.Porto.Core.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Porto.Implementation.Scripts.InteractionSystem
{
    /// <summary>
    /// Implementasi IInteractable.
    /// </summary>
    public abstract class Interactable : MonoBehaviour, IInteractable
    {
        #region IInteractable

        public abstract void InteractAction();

        #endregion
    }
}
