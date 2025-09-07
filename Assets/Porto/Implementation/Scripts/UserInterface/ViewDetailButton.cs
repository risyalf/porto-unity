using Assets.Porto.Core.Scripts;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Porto.Implementation.Scripts.UserInterface
{
    /// <summary>
    /// Menangani tombol untuk melihat detail.
    /// </summary>
    public class ViewDetailButton : MonoBehaviour
    {
        #region Variables

        /// <summary>
        /// Menangani semua interaksi yang ada didalam game.
        /// </summary>
        private IInteractManager interactManager = null;

        /// <summary>
        /// Tombol yang digunakan untuk mengaktifkan interaksi.
        /// </summary>
        private Button _button = null;

        #endregion

        #region Main

        private void ChangedInteractable(IInteractable interactable)
        {
            if (interactable != null)
            {
                gameObject.SetActive(true);

                return;
            }

            gameObject.SetActive(false);
        }

        #endregion

        #region Mono

        private void Awake()
        {
            interactManager = FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.InstanceID).OfType<IInteractManager>().First();
            _button = gameObject.GetComponent<Button>();

            _button.onClick.AddListener(interactManager.DoInteract);

            interactManager.RegisterInteract += ChangedInteractable;
        }

        private void Start()
        {
            gameObject.SetActive(false);
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(interactManager.DoInteract);
            interactManager.RegisterInteract -= ChangedInteractable;
        }

        #endregion
    }
}
