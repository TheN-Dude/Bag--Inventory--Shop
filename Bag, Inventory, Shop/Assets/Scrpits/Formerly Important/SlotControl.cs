using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotControl : MonoBehaviour
{
    bool addedAlready = false;
    Inventory inve;
   public GameObject GOInventory;
    public bool flag = false;
    
    // Start is called before the first frame update
   /* void Start()
    {
        inve = GameObject.Find("Inventory").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount != 0)
        {
            updatlist();
        }
    }


   /* public void RestList()
    {
        for(int i = 0; i < inve.itemList.Count; i++)
        {

            inve.itemList.RemoveAt(i);

        }



    }*/



   /* public void updatlist()
    {


   
        
            var pos = transform.GetChild(0).gameObject;

            if (transform.childCount > 0)
            {
                if (!addedAlready)
                {
                    addedAlready = true;
                    Debug.Log(pos.name);
                    // inve.itemList.Add(pos);
                    inve.AddtoList(flag, pos);
                }


            }
            Debug.Log("updatlist test");
        
       

    }
   */
}
