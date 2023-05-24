using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    RectTransform RectTform;
    CanvasGroup CanGrp;

    Canvas canVas;
    [HideInInspector] public Transform parentafterdrag;

   
    Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        RectTform = GetComponent<RectTransform>();
        CanGrp = GetComponent<CanvasGroup>();
        canVas = GameObject.Find("Canvas").GetComponent<Canvas>();
        inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
    }


     public void OnBeginDrag(PointerEventData eventData)
     {
        // Debug.Log("Bdrag");
        CanGrp.blocksRaycasts = false;
        parentafterdrag = transform.parent;
        transform.SetParent(transform.root); //points towards the root parent, so in this case the canvas
        transform.SetAsLastSibling(); //places above everything because it is the last siblings at the top.
        inventory.RestListy();
     }

    public void OnDrag(PointerEventData eventData)
    {
        inventory.RestListy();

        //  Debug.Log("OD");
        RectTform.anchoredPosition += eventData.delta / canVas.scaleFactor;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
      //  Debug.Log("Edrag");
        CanGrp.blocksRaycasts = true;
        transform.SetParent(parentafterdrag); //once the drag is done, it sets where it is placed as this object's parent(tied with the JustDrop Script)
        inventory.RestListy();
        inventory.VUpadteIven();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
       // Debug.Log("Pt");
    }

    
    

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
