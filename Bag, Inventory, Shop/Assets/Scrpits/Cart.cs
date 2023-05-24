using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cart : MonoBehaviour, IDropHandler
{
  Inventory invent;
    Items items;
    //SlotControl cs_control;
   

   

    public void setObj(GameObject item_)
    {
        Debug.Log(item_);
    }
    public void OnDrop(PointerEventData eventData)
    {
       // Debug.Log("On Drop");
      
           

            if (eventData.pointerDrag != null) //if the drag is done the this code runs
            {
                Debug.Log("dRAG IS DONE");
                //invent.RestListy();
               

                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                DragAndDrop dragAndDrop = eventData.pointerDrag.GetComponent<DragAndDrop>(); //Accesing the D&D script and making it realted with this scrpit

                //linked with the drag&Drop scrpit. So the object's, with D&D scrpit's, transform will equal the transform of the object with this JustDrop Scrpit.
                //(So making the D&D object, the child of the JustDrop Object)
                dragAndDrop.parentafterdrag = transform;
                // transform.GetChild(0).gameObject;

               // cs_control.updatlist();

                // itemList.Add(GetComponentInChildren<RectTransform>());
                if (transform.childCount != 0)
                {
                   // invent.SwitchiUp(transform.GetChild(0).gameObject);
                    Debug.Log(transform.GetChild(0).gameObject);
                }
                

            


        }

       
    }

    // Start is called before the first frame update
    void Start()
    {
       
       invent = GameObject.Find("Inventory").GetComponent<Inventory>();

       


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
