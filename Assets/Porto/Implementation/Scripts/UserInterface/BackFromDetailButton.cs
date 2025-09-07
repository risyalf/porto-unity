using Assets.Porto.Core.Scripts;
using Porto.Core.Scripts;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Porto.Implementation.Scripts.UserInterface
{
    /// <summary>
    /// Menangani tombol keluar dari detail.
    /// </summary>
    public class BackFromDetailButton : MonoBehaviour
    {
        #region Variables

        /// <summary>
        /// Target yang ada di game.
        /// </summary>
        private ITarget<GameObject> target = null;

        /// <summary>
        /// GameObject Player.
        /// </summary>
        private GameObject _player = null;

        /// <summary>
        /// Tombol yang digunakan untuk mengaktifkan interaksi.
        /// </summary>
        private Button _button = null;

        #endregion

        #region Main

        /// <summary>
        /// Untuk reset target.
        /// </summary>
        private void ResetTarget()
        {
            target.ChangeTarget(_player);
        }

        #endregion

        #region Mono

        private void Awake()
        {
            _button = gameObject.GetComponent<Button>();

            _button.onClick.AddListener(ResetTarget);

            target = FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.None).OfType<ITarget<GameObject>>().First();

            _player = GameObject.Find("Player");

            gameObject.SetActive(false);
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(ResetTarget);
        }

        #endregion
    }
}
