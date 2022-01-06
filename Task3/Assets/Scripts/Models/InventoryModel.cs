using System;
using System.Collections.Generic;
using System.Linq;
using Items;
using Inventory;
namespace Inventory
{
    public class InventoryModel : IInventoryModel
    {
        private readonly List<IItem> _items = new List<IItem>();

        //private List<IInventorySlot> _slots;
        

        public IReadOnlyList<IItem> GetEquippedItems()
        {
            return _items;
        }

        public void EquipItem(IItem item)
        {
            if (_items.Contains(item))
                return;
            
            _items.Add(item);
        }

        public void UnequipItem(IItem item)
        {
            if (!_items.Contains(item))
                return;
            
            _items.Remove(item);
        }
    }
}