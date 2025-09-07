using UnityEngine;

namespace Porto.Core.Scripts
{
    /// <summary>
    /// Menangani input yang diberikan oleh user.
    /// </summary>
    public interface IInput
    {
        /// <summary>
        /// Id dari input.
        /// </summary>
        string ID { get; }

        /// <summary>
        /// Method untuk disable input.
        /// </summary>
        /// <param name="disable">
        /// Apakah input disable atau tidak.
        /// </param>
        void SetDisable(bool disable);
    }
    /// <summary>
    /// Menangani input yang dilakukan oleh user.
    /// </summary>
    public interface IInput<T> : IInput
    {
        /// <summary>
        /// Nilai dari input.
        /// </summary>
        T Value { get; }
    }
}