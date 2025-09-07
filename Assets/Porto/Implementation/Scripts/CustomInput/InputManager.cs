using Porto.Core.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Porto.Implementation.Scripts.CustomInput
{
    /// <summary>
    /// Menangani semua input yang ada di game.
    /// </summary>
    public class InputManager: MonoBehaviour
    {
        #region Variables

        /// <summary>
        /// Semua input yang ada di game.
        /// </summary>
        private IInput[] inputs = null;

        /// <summary>
        /// Target kamera saat ini.
        /// </summary>
        private ITarget<GameObject> cameraTarget = null;

        #endregion

        #region Main

        private void CheckTarget(string objectName)
        {
            if (objectName == "Player") 
            {
                Array.ForEach(inputs, input => input.SetDisable(false));

                return;
            }

            Array.ForEach(inputs, input => input.SetDisable(true));
        }

        #endregion

        #region Mono

        private void Awake()
        {
            inputs = FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.None).OfType<IInput>().ToArray();
            cameraTarget = FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.None).OfType<ITarget<GameObject>>().First();

            cameraTarget.OnChangeTarget += CheckTarget;
        }

        private void OnDestroy()
        {
            cameraTarget.OnChangeTarget -= CheckTarget;
        }

        #endregion
    }
}
