using System;
using UnityEngine;

namespace Assets.Porto.Core.Scripts
{
    /// <summary>
    /// Menangani object yang dapat di interaksikan.
    /// </summary>
    public interface IInteractable
    {
        /// <summary>
        /// Melakukan sesuatu bila berinteraksi dengan object.
        /// </summary>
        void InteractAction();
    }
}