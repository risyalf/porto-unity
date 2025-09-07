using Assets.Porto.Core.Scripts;
using System;
using UnityEngine;

namespace Assets.Porto.Implementation.Scripts.InteractionSystem
{
    /// <summary>
    /// Menangani semua interaksi yang ada didalam game.
    /// </summary>
    public class InteractionManager : MonoBehaviour, IInteractManager
    {
        #region IInteractManager

        public void DoInteract()
        {
            Interactable.InteractAction();
        }

        public IInteractable Interactable { get; private set; } = null;

        public Action<IInteractable> RegisterInteract { get; set; }

        #endregion

        #region Main

        private void RegisterInteractable(IInteractable interactable)
        {
            Interactable = interactable;
        }

        #endregion

        #region Mono

        private void Awake()
        {
            RegisterInteract += RegisterInteractable;
        }

        private void OnDestroy()
        {
            RegisterInteract -= RegisterInteractable;
        }

        #endregion
    }
}
