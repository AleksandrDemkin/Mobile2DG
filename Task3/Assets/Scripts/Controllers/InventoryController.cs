using System;
using System.Collections.Generic;
using Controllers;
using Items;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Inventory
{
    public class InventoryController : BaseController, IInventoryController
    {
        private readonly IInventoryModel _inventoryModel;
        private readonly IInventoryView _inventoryView;
        private readonly IItemsRepository _itemsRepository;
        private readonly ResourcePath _viewItemsPanelPath = new ResourcePath {PathResource = "Prefabs/ItemsPanel"};

        public InventoryController(Transform placeForUi, List<ItemConfig> itemConfigs)
        {
            _inventoryModel = new InventoryModel();
            _inventoryView = new InventoryView();
            _itemsRepository = new ItemsRepository(itemConfigs);
            _inventoryView = LoadInventoryView(placeForUi);
        }

        public InventoryView LoadInventoryView(Transform placeForUi)
        {
            var objView = Object.Instantiate(ResourceLoader.LoadPrefab(_viewItemsPanelPath), placeForUi, false);
            AddGameObjects(objView);
        
            return objView.GetComponent<InventoryView>();
        }

        public void ShowInventory()
        {
            foreach (var item in _itemsRepository.Items.Values)
                _inventoryModel.EquipItem(item);

            var equippedItem = _inventoryModel.GetEquippedItems();
            _inventoryView.Display(equippedItem);
        }

        public void HideInventory()
        {
            throw new NotImplementedException();
        }
    }
}