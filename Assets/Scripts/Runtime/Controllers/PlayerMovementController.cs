using System;
using Runtime.Data.ValueObjects;
using Runtime.Keys;
using Runtime.Managers;
using Unity.Mathematics;
using UnityEngine;

namespace Runtime.Controllers
{
    public class PlayerMovementController: MonoBehaviour
    {
        #region Self Veriables

        #region Serialized Veriables

        [SerializeField] private PlayerManager manager;
        

        #endregion

        #region Private Veriables

        private float2 _inputvalues;
        private Rigidbody _rigidbody;
        private PlayerMovementData _data;

        #endregion

        #endregion

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        internal void OnInputTaken(InputParams inputparams)
        {
            _inputvalues = inputparams.InputValues;
        }
        
        private void FixedUpdate()
        {
            MovePlayer();
        }

        private void MovePlayer()
        {
            _rigidbody.velocity += new Vector3(_inputvalues.x, 0,
                z:_inputvalues.y  * (_data.Speed * Time.deltaTime));
        }

        public void SetMovementData(PlayerMovementData movementData)
        {
            _data = movementData;
        }

    }
}