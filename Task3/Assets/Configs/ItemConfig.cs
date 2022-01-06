using UnityEngine;

namespace Items
{
    [CreateAssetMenu(fileName = "ItemConfig", menuName = "ItemConfig", order = 0)]

    public class ItemConfig : ScriptableObject
    {
        [SerializeField] private int _id;
        
        [SerializeField] private string _title;

        [SerializeField] private Texture2D _uIIcon;
        
        [SerializeField] private int _maxItemInSlot;
        
        [SerializeField] private int _amount;
        
        

        public int Id =>  _id;
        public string Title => _title;

        public Texture2D UIIcon => _uIIcon;

        public int MaxItemInSlot => _maxItemInSlot;
        
        public int amount => _amount;
    }
}
