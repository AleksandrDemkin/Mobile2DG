﻿using System;
using System.Collections.Generic;
using System.Linq;
using Configs;
using Controllers;
using Inventory;
using Items;
using JetBrains.Annotations;
using Models;
using UnityEngine;
using Upgrades;

namespace Shed
{
    public class ShedController : BaseController, IShedController
    {
        /*private readonly CarModel _car;
        
        private readonly UpgradeHandlersRepository _upgradeHandlersRepository;
        private readonly ItemsRepository _upgradeItemsRepository;
        private readonly InventoryModel _inventoryModel;
        private readonly InventoryController _inventoryController;
        
        public ShedController(
            [NotNull] List<UpgradeItemConfig> upgradeItemConfigs,
            [NotNull] CarModel car)
        {
            if (upgradeItemConfigs == null) throw new
                ArgumentNullException(nameof(upgradeItemConfigs));
            
            _car = car ?? throw new ArgumentNullException(nameof(car));
            
            _upgradeHandlersRepository
                = new UpgradeHandlersRepository(upgradeItemConfigs);
            AddController(_upgradeHandlersRepository);
            
            _upgradeItemsRepository
                = new ItemsRepository(upgradeItemConfigs.Select(value =>
                    value.itemConfig).ToList());
            AddController(_upgradeItemsRepository);
            
            _inventoryModel = new InventoryModel();
            _inventoryController
                = new InventoryController(_inventoryModel, _upgradeItemsRepository);
            AddController(_inventoryController);
        }
        
        public void Enter()
        {
            _inventoryController.ShowInventory(Exit);
            Debug.Log($"Enter: car has speed : {_car.Speed}");
        }
        public void Exit()
        {
            UpgradeCarWithEquippedItems(
                _car, _inventoryModel.GetEquippedItems(), _upgradeHandlersRepository.UpgradeItems);
            Debug.Log($"Exit: car has speed : {_car.Speed}");
        }
        
        private void UpgradeCarWithEquippedItems(
            IUpgradableCar upgradableCar,
            IReadOnlyList<IItem> equippedItems,
            IReadOnlyDictionary<int, IUpgradeCarHandler> upgradeHandlers)
        {
            foreach (var equippedItem in equippedItems)
            {
                if (upgradeHandlers.TryGetValue(equippedItem.Id, out var handler))
                {
                    handler.Upgrade(upgradableCar);
                }
            }
        }*/
        public void Enter()
        {
            throw new NotImplementedException();
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }
    }
}