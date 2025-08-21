using UnityEngine;

namespace Porto.Core.Scripts
{
    /// <summary>
    /// Menangani object yang bisa di integraksi.
    /// </summary>
    public interface IInteract
    {
        void DoInteract();

        void FinishInteract();
    }
}
