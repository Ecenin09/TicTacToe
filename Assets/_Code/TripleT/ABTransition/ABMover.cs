using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace Transition
{
    public class ABMover : MonoBehaviour
    {
        #region Fields

        public bool IsActive => _isActive;

        #endregion

        #region Parameters
        [SerializeField] private GameObject objectToMove = default;
        [SerializeField] private RectTransform fromA = default;
        [SerializeField] private RectTransform toB = default;
        [SerializeField] private float _delayTime = default;
        private bool _isActive = false;
        #endregion


        

        public void MakeTransition(float deltaTime)
        {
            
            if (fromA != null && toB != null)
            {
                
            }
            
        }


        private void Update()
        {
            if (_isActive)
            {
                if (objectToMove.transform.Equals(fromA))
                {
                }
            }
        }
    }
}