using Assets.Porto.Core.Scripts;
using Porto.Core.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Porto.Implementation.Scripts.InteractionSystem
{
    /// <summary>
    /// Implementasi Interactable.
    /// </summary>
    public class InteractPanel: Interactable
    {
        #region Variable

        /// <summary>
        /// Posisi dari panel yang di ikuti oleh kamera.
        /// </summary>
        private GameObject _panelPosition = null;

        /// <summary>
        /// Target dari posisi kamera.
        /// </summary>
        private ITarget<GameObject> target = null;

        /// <summary>
        /// Menangani semua iteraksi pada game.
        /// </summary>
        private IInteractManager interactManager = null;

        #endregion

        #region Interactable

        public override void InteractAction()
        {
            target.ChangeTarget(_panelPosition);
        }

        #endregion

        #region Mono

        private void Awake()
        {
            target = FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.InstanceID).OfType<ITarget<GameObject>>().Where(x => x.ID == "Camera").First();
            interactManager = FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.InstanceID).OfType<IInteractManager>().First();
            _panelPosition = transform.GetChild(0).gameObject;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name == "Player")
            {
                interactManager.RegisterInteract(this);
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.name == "Player")
            {
                interactManager.RegisterInteract(null);
            }
        }

        #endregion
    }
}
