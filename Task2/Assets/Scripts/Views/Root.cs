﻿using AnalyticsTools;
using Controllers;
using Models;
using Profile;
using UnityEngine;

namespace Views
{
    public class Root : MonoBehaviour
    {
        [SerializeField] private Transform _placeForUi;

        [SerializeField] private AdsTools _adsTools;

        private MainController _mainController;
        
        private void Awake()
        {
            var profilePlayer = new ProfilePlayer(15f, _adsTools);
            profilePlayer.CurrentState.Value = GameState.Start;
            _mainController = new MainController(_placeForUi, profilePlayer);
        }

        protected void OnDestroy()
        {
            _mainController?.Dispose();
        }
    }
}