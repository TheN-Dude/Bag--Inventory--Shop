using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ItemSpawner : MonoBehaviour
{

    public GameObject BlueLock2;
    public GameObject PurpLock;
    public GameObject See;
    public GameObject Up;
    public GameObject Down;
    public GameObject Heal;
    //public Button buut;
    Resell reselling;

    public SOjs data;
    public SOjs dataPL;
    public SOjs dataS;
    public SOjs dataU;
    public SOjs dataD;
    public SOjs dataH;
    public SOjs dataE;
    public SOjs dataCH;
    public TMP_Text Cash;
    
    //ButtonCheck ButtCh;



    int Allowance = 100;
    public int currentMoney;
    public GameObject Cart;
    


    // Start is called before the first frame update
    void Start()
    {

        currentMoney = Allowance;

       // ButtCh = buut.GetComponent<ButtonCheck>();

       


    }

    // Update is called once per frame
    void Update()
    {

        //Extendo();  Check as to how to limit a button press minus in Update //No need because you figured out how to just use OnClick.
        //You tried Fixed

        Cash.text = currentMoney.ToString("0");

    }





    //These are Instatiate Functions used to instatiate the object, and everytime it does so it subtracts money from data.Cost(Scriptable Object int variable)

    public void Instantiate()
    {

        

        if (currentMoney >= data.Cost)
        {
            currentMoney = currentMoney - data.Cost;

            var BLL = Instantiate(BlueLock2, Cart.transform );     //var BLL is equal to the instatiated object
          
         //this makes the Intsnatiated object's transform = to that of the Object with this Item Spawner Script. So the parent of the object with this scrpit, is the parent of the instantiated object
          // BLL.transform.SetParent(transform.parent, false); 
            Debug.Log(currentMoney);
        }
        else
        {
            Debug.Log("No Damseles");
        }

    }

    public void Instantiate2()
    {
        if (currentMoney >= dataPL.Cost)
        {
            currentMoney = currentMoney - dataPL.Cost;

            var PLL = Instantiate(PurpLock, Cart.transform); //This instantiates the object to the place of the object, but as well as the child of the object
            //PLL.transform.SetParent(transform.parent, false);
            Debug.Log(currentMoney);
        }
        else
        {
            Debug.Log("No Damseles");
        }



    }

    public void Instantiate3()
    {
        if (currentMoney >= dataS.Cost)
        {
            currentMoney = currentMoney - dataS.Cost;

            var SLL = Instantiate(See, Cart.transform);
           // SLL.transform.SetParent(transform.parent, false);
           Debug.Log(currentMoney);
        }
        else
        {
            Debug.Log("No Damseles");
        }
    }
        public void Instantiate4()
        {
            if (currentMoney >= dataH.Cost)
            {
                currentMoney = currentMoney - dataH.Cost;

                var HLL = Instantiate(Heal, Cart.transform);
               // HLL.transform.SetParent(transform.parent, false);
               Debug.Log(currentMoney);
            }
            else
            {
                Debug.Log("No Damseles");
            }



        }

    public void Instantiate5()
    {
        if (currentMoney >= dataD.Cost)
        {
            currentMoney = currentMoney - dataD.Cost;

            var DLL = Instantiate(Down, Cart.transform);
           // DLL.transform.SetParent(transform.parent, false);
            Debug.Log(currentMoney);
        }
        else
        {
            Debug.Log("No Damseles");
        }



    }


    public void Instantiate6()
    {
        if (currentMoney >= dataU.Cost)
        {
            currentMoney = currentMoney - dataU.Cost;

            var ULL = Instantiate(Up, Cart.transform);
            //ULL.transform.SetParent(transform.parent, false);
            //Debug.Log(currentMoney);
        }
        else
        {
            Debug.Log("No Damseles");
        }



    }

    //Used for Inventory Expand Function
    public void Extendo()
    {
       // if (ButtCh.ButtonPressed == true)
       // {
            if (currentMoney >= dataE.Cost)
            {
                currentMoney = currentMoney - dataE.Cost;
                //Debug.Log(currentMoney);
            }



       // }
    }

    public void ChestUpgarde()
    {
        
        if (currentMoney >= dataCH.Cost)
        {
            currentMoney = currentMoney - dataCH.Cost;
            
        }

    }

  
   

}

