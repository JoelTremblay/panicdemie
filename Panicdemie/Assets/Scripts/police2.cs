using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class police2 : MonoBehaviour
{
    public GameObject interactionPolice;
    public GameObject menuPolice;
    public static bool inTrigger3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (marchand.frozen == false)
        {
            if(inTrigger3 && Input.GetKeyDown(KeyCode.E)) 
            {
                interactionPolice.gameObject.SetActive(!interactionPolice.gameObject.activeSelf);
                menuPolice.gameObject.SetActive(!menuPolice.gameObject.activeSelf);
                marchand.frozen = true;
            }
        }
        else 
        {
            if(inTrigger3 && Input.GetKeyDown(KeyCode.E)) 
            {
                interactionPolice.gameObject.SetActive(!interactionPolice.gameObject.activeSelf);
                menuPolice.gameObject.SetActive(!menuPolice.gameObject.activeSelf);
                marchand.frozen = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
            {
                interactionPolice.SetActive(true);
                inTrigger3 = true;
            }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        interactionPolice.SetActive(false);
        inTrigger3 = false;
    }
}
