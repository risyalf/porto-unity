using UnityEngine;

namespace Porto.Core.Scripts
{
    /// <summary>
    /// Menangani input yang dilakukan oleh user.
    /// </summary>
    public interface IInput<T>
    {
        /// <summary>
        /// Nilai dari input.
        /// </summary>
        T Value { get; }

        /// <summary>
        /// Method untuk disable input.
        /// </summary>
        /// <param name="disable">
        /// Apakah input disable atau tidak.
        /// </param>
        void SetDisable(bool disable);
    }
}