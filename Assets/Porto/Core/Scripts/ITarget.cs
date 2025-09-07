using System;
using UnityEngine;

namespace Porto.Core.Scripts
{
    /// <summary>
    /// Menangani target.
    /// </summary>
    public interface ITarget
    {
        /// <summary>
        /// Id dari target.
        /// </summary>
        string ID { get; }

        /// <summary>
        /// Event yang dipanggil ketika target di ganti.
        /// </summary>
        Action<string> OnChangeTarget { get; set; }
    }

    /// <summary>
    /// Menangani target.
    /// </summary>
    /// <typeparam name="T">
    /// Jenis target.
    /// </typeparam>
    public interface ITarget<T> : ITarget
    {
        /// <summary>
        /// Target saat ini.
        /// </summary>
        T CurrentTarget { get; }

        /// <summary>
        /// Untuk mengganti target.
        /// </summary>
        /// <param name="newTarget">
        /// Target baru.
        /// </param>
        void ChangeTarget(T newTarget);
    }
}
