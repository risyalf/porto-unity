using System;

namespace Assets.Porto.Core.Scripts
{
    /// <summary>
    /// Menangani semua interaksi yang ada didalam game.
    /// </summary>
    internal interface IInteractManager
    {
        /// <summary>
        /// Untuk melakukan interaksi.
        /// </summary>
        void DoInteract();

        /// <summary>
        /// Interactable yang di register saat ini.
        /// </summary>
        IInteractable Interactable { get; }

        /// <summary>
        /// Untuk register interactable.
        /// </summary>
        Action<IInteractable> RegisterInteract { get; set; }
    }
}
