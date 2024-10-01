using UnityEngine;

namespace Scenes.Scripts
{
    [System.Serializable]
    public class Item
    {
        public string itemName;
        public int itemID = 1;
        [SerializeField] private bool isDefault;
        [SerializeField] private float damageOnHit;
        [SerializeField] private bool inInventory;
        [SerializeField] private Sprite icon;

        public bool IsDefault => isDefault;
        public float DamageOnHit => damageOnHit;
        public bool InInventory => inInventory;
        public Sprite Icon => icon;

        public void PickUpItem()
        {
            if (!inInventory)
            {
                inInventory = true;
                Debug.Log($"{itemName} picked up!");
                // Additional logic can be added here
            }
        }
    }
}