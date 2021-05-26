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
    public GameObject inventairePerso;
    public GameObject joueur;
    public static bool inTrigger;
    public static bool frozen;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (frozen == false)
        {
            if(inTrigger && Input.GetKeyDown(KeyCode.E)) 
            {
                interactionMarchand.gameObject.SetActive(!interactionMarchand.gameObject.activeSelf);
                inventairePerso.transform.localPosition = new Vector3(-400, 0, 0);
                inventairePerso.gameObject.SetActive(!inventairePerso.gameObject.activeSelf);
                menuMagasin.transform.localPosition = new Vector3(479, 0, 0);
                frozen = true;
            }
        }
        else 
        {
            if(inTrigger && Input.GetKeyDown(KeyCode.E)) 
            {
                interactionMarchand.gameObject.SetActive(!interactionMarchand.gameObject.activeSelf);
                inventairePerso.transform.localPosition = new Vector3(0, 0, 0);
                inventairePerso.gameObject.SetActive(!inventairePerso.gameObject.activeSelf);
                menuMagasin.transform.localPosition = new Vector3(479, 2000, 0);
                frozen = false;
            }

            if(GameObject.Find("ButtonPauseMenu"))
            {
                menuMagasin.transform.localPosition = new Vector3(479, 2000, 0);
            }
            else if(!GameObject.Find("ButtonPauseMenu") && frozen == false)
            {
                inventairePerso.transform.localPosition = new Vector3(0, 0, 0);
            }
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
