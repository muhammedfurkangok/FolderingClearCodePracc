using System;
using Runtime.Controllers;
using Runtime.Data.UnityObjects;
using Runtime.Data.ValueObjects;
using Runtime.Signals;
using UnityEngine;

namespace Runtime.Managers
{
    public class PlayerManager : MonoBehaviour
    {
        #region Self Variables

        #region Serialized Veriables

        [SerializeField] private PlayerMovementController movementcontroller;

        #endregion

        #region Private Veriables

        private PlayerData _data;

        #endregion

        #endregion

        private void Awake()
        {
            GetPlayerData();
            SendDataToController();
        }

        private void GetPlayerData()
        {
            _data = Resources.Load<CD_Player>($"Data/CD_Player").Data;
        }

        private void OnEnable()
        {
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            InputSignals.Instance.onInputTaken += movementcontroller.OnInputTaken;
        }

        private void UnsubscribeEvents()
        {
            InputSignals.Instance.onInputTaken -= movementcontroller.OnInputTaken;
        }

        private void OnDisable()
        {
            UnsubscribeEvents();
        }

        public void SendDataToController()
        {
            movementcontroller.SetMovementData(_data.MovementData);
        }
    }
}