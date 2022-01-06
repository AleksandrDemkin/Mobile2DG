using System;
using System.Collections.Generic;
using Items;
using UnityEngine;

namespace Inventory
{
    public class InventoryView : MonoBehaviour, IInventoryView
    {
        public event EventHandler<IItem> Selected;
        public event EventHandler<IItem> Deselected;

        

        public void Display(IReadOnlyList<IItem> items)
        {
            foreach (var item in items)
            {
                Debug.Log($"Id item: {item.Id}, title: {item.Info.Title}");
            }
        }

    }
}