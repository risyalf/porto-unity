using Porto.Core.Scripts;
using UnityEngine;

namespace Porto.Implementation.Scripts.Attribute
{
    /// <summary>
    /// Implementasi ISpeed.
    /// </summary>
    public class Speed : MonoBehaviour, ISpeed
    {
        #region Variables

        [SerializeField]
        private float value = 0;
        
        [SerializeField]
        private float valueBoost = 0;

        #endregion
        
        #region ISpeed

        public float Value => value;

        public float ValueBoost => valueBoost;

        #endregion
    }
}