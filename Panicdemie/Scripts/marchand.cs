using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Ouverture de l'interface du marchand.
 * Par : Joël Tremblay
*/
public class marchand : MonoBehaviour
{
    public GameObject interactionMarchand;
    public GameObject menuMagasin;
    public GameObject joueur;
    public bool inTrigger;
    public static bool frozen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inTrigger && Input.GetKeyDown(KeyCode.E)) 
        {
            menuMagasin.gameObject.SetActive(!menuMagasin.gameObject.activeSelf);
            frozen = true;

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.gameObject.tag == "Player")
            {

                interactionMarchand.SetActive(true);
                inTrigger = true;

            }

    }

    void OnTriggerExit2D(Collider2D other)
    {

        interactionMarchand.SetActive(false);
        inTrigger = false;

    }


}