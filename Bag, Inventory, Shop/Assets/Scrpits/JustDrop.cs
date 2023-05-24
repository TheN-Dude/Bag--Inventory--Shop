using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JustDrop : MonoBehaviour, IDropHandler
{
  Inventory invent;
    Items items;
    //SlotControl cs_control;
   

    public GameObject BlueLock2;
    public GameObject PurpLock;
    public GameObject See;
    public GameObject Up;
    public GameObject Down;
    public GameObject Heal;


    public void setObj(GameObject item_)
    {
        Debug.Log(item_);
    }
    public void OnDrop(PointerEventData eventData)
    {
       // Debug.Log("On Drop");
      if (transform.childCount == 0) //Meaning if there is no children in the object, then you can drop an object in there. But if there is 1, then code does not run
        {
           

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

       
    }

    // Start is called before the first frame update
    void Start()
    {
       
       invent = GameObject.Find("Inventory").GetComponent<Inventory>();

        items = BlueLock2.GetComponent<Items>();
        items = PurpLock.GetComponent<Items>();
        items = Up.GetComponent<Items>();
        items = Down.GetComponent<Items>();
        items = BlueLock2.GetComponent<Items>();
        items = Heal.GetComponent<Items>();



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
