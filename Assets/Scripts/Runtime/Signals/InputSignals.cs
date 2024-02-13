using System;
using Runtime.Keys;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;

namespace Runtime.Signals
{
    public class InputSignals : MonoBehaviour
    {
        #region Singleton

        public static InputSignals Instance;
        private void Awake()
        {
            if (Instance != null && Instance !=this)
            {
                Destroy(gameObject);
                return;
            }
            
            Instance = this;
            
        }
        #endregion

        public UnityAction<InputParams> onInputTaken = delegate { };
    }
}