using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> itemList;
    public List<Item> ItemList => itemList; 
    void Start()
    {
        itemList = new List<Item>();
        for (int i=0; i<10;i++){AddItem(new Item("screwDriver", "Screw-Driver"));}
        
        AddItem(new Item("screwDriver", "Screw-Driver"));
        AddItem(new Item("teeth", "Teeth"));
    }
    // Add an Item to the inventory. Given the item to add.
    public void AddItem(Item item){
        itemList.Add(item);
    }
    public void AddItem(string name, string itemType)
    {
        itemList.Add(new Item(name, itemType));
    }
    public void AddItem(string name)
    {
        itemList.Add(new Item(name, name));
    }
    // Checks to see if an item that shares it itemType with the string exists
    // Check to see if an item exists in inventory
    public bool HasItem(string item){
        return (getItem(item) != null);     // If its given an item, it returns true. Else, it returns false.
    }
    // Using the string, it finds an Item in the itemList that shares the itemType
    // If none exists, it returns null
    public Item getItem(string item){
        foreach (Item checkItem in itemList){               // Checks through all the items in itemList
            if ( checkItem.GetItemType().Equals( item ) ){  // If the item shares the same itemType as the given string
                return checkItem;                           // Returns the item
            }
        }
        return null;    // If no item exists in the inventory, returns null
    }
    // Removes the item from the itemList
    // Given the itemType string, uses getItem function to find the Item to delete it
    public void RemoveItem(string item){
        itemList.Remove(getItem(item));
        //Debug.Log( $"Removed: {item}"  );
    }
    // Gives the itemList
    public List<Item> GetItemList(){
        return itemList;
    }
}

