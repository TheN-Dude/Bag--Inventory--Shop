using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateShop : MonoBehaviour
{

    public GameObject Special;
    public GameObject ComingSoon;
    float currentTime;
    float startTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += 1 * Time.deltaTime;

        if(currentTime >= 30)
        {
            Special.SetActive(true);
            ComingSoon.SetActive(false);
        }

       // Debug.Log(currentTime);

    }
}
