using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


//Due to the better method of just using the onclick method, this script is Unnecceasry  
public class ButtonCheck : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool ButtonPressed;


    public void OnPointerDown(PointerEventData eventData)
    {
        ButtonPressed = true; //When the mouse button is down, Button pressed is true
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ButtonPressed = false; //When the mouse button is up, Button pressed is false
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
