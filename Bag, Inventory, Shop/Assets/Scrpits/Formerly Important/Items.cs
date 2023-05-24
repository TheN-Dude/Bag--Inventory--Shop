using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Items : MonoBehaviour
{

    public ItemType IT;

    public enum ItemType
    {

        PurpleLock,
        BlueLock,
        Health,
        Eye,
        Up1,
        Down,
        Extra,
    }


    ItemSpawner itemSpawner;
    Inventory invent;
   // GameObject Inventory;
   // GameObject ISpawn;
    


    // Start is called before the first frame update
    void Start()
    {
        invent = GameObject.Find("Inventory").GetComponent<Inventory>();
        itemSpawner = GameObject.Find("ItemBuying").GetComponent<ItemSpawner>();


        
    }

   



}             
