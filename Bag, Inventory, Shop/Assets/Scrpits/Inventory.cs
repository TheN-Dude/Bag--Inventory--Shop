using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public List<GameObject> itemList = new List<GameObject>();
    
    Items Item;
   // ItemSpawner item;

    public GameObject BlueLock2;
    public GameObject PurpLock;
    public GameObject See;
    public GameObject Up;
    public GameObject Down;
    public GameObject Heal;

    public GameObject[] Slots;
    

    //public string Name_; //CHnage the name here Name_= gameObject.name
    // Start is called before the first frame update
    void Start()
    {
        itemList = new List<GameObject>();
        //items = GameObject.Find("ItemBuying").GetComponent<ItemSpawner>();
    }

    public void AddtoList(bool flag, GameObject item)
    {
        flag = true;

        itemList.Add(item);


    }

    public void RestListy()
    {
        Debug.Log("rEST YUHH");
        for (int i = 0; i < itemList.Count; i++)
        {

            itemList.RemoveAt(i);

        }
    }

    public void VUpadteIven()
    {
        Debug.Log("uPDATE YEAH");
        for(int i = 0; i < Slots.Length; i++)
        {
            Debug.Log(Slots[i].name);
            if (Slots[i].gameObject.transform.childCount != 0)
            {
                itemList.Add(Slots[i].transform.GetChild(0).gameObject);
            }
            else
            {
                Debug.Log("Empty");
            }
           
        }

       
    }

    public void ResortBag()
    {
        

    }


    void Update()
    {

       // VUpadteIven();

    }
    /* public void SwitchiUp(GameObject itemtype)
     {
         Name_ = itemtype.name;

         switch (Name_)
         {
             case "PLock":
                 AddItem2();

                 break;

             case Items.ItemType.BlueLock:
                 AddItem1();

                 break;

             case Items.ItemType.Down:
                 AddItem5();

                 break;

             case Items.ItemType.Eye:
                  AddItem3();

                 break;

             case Items.ItemType.Health:
                  AddItem4();

                 break;

             case Items.ItemType.Up1:
                  AddItem6();

                 break;
                    }


     } 
     public void AddItem1()
     {

         itemList.Add(BlueLock2);
     }


     public void AddItem2()
     {

         itemList.Add(PurpLock);
     }

     public void AddItem3()
     {

         itemList.Add(See);
     }

     public void AddItem4()
     {

         itemList.Add(Heal);
     }

     public void AddItem5()
     {

         itemList.Add(Down);
     }

     public void AddItem6()
     {

         itemList.Add(Up);
     } */

}
