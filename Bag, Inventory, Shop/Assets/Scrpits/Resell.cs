using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Resell : MonoBehaviour, IDropHandler
{
  Inventory invent;
    Items items;
    //SlotControl cs_control;

    public SOjs data;
    public SOjs dataPL;
    public SOjs dataS;
    public SOjs dataU;
    public SOjs dataD;
    public SOjs dataH;
    public SOjs dataE;
    public SOjs dataCH;




    ItemSpawner Money;
    public GameObject Shopping;

    private void Start()
    {

        Money = Shopping.GetComponent<ItemSpawner>();
    }


    public void OnDrop(PointerEventData eventData)
    {
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

                

            }

        }
    }
    public void Selling()
    {

        Destroy(transform.GetChild(0).gameObject);
        Money.currentMoney = Money.currentMoney + data.Cost;

    }




}
