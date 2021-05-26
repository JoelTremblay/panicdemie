using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
/* Gestion des déplacements et collisions de LILO
 * Par : ANGÉLICA Montufar
 * Dernière modif : 14 avril 2021
 * Illustations fait par Angélica MM et Script
 */
public class persoPrincipal : MonoBehaviour
{

    

    public float vitesseX; // déplacement dans l'axe horizontale
    public float vitesseY; // déplacement dans l'axe verticale
    public float vitesseSaut=10;
    public float vitesseNormale=5;


    public Text compteurArgent;
    public static int compteur = 0;

    public static int compteurObjets = 0;
    public static int compteurEnnemis = 0;

    private bool partieTermnine= false;

    // Start is called before the first frame update
    void Start()
    {

        compteur = 0;
        compteurObjets = 0;
        compteurEnnemis = 0;

    }

    // Update is called once per frame
    void Update()
    {
            if (partieTermnine == false)//si la partie n'est pas perdu
        {
            if (marchand.frozen == false)
            {
            if (Input.GetKey(KeyCode.LeftArrow)) // vers la gauche
            {
                
                print(KeyCode.LeftArrow);
                vitesseX = -vitesseNormale;
                GetComponent<SpriteRenderer>().flipX=true;
                
            }

            else if (Input.GetKey(KeyCode.RightArrow)) //vers la droite
            {

                print(KeyCode.RightArrow);
                vitesseX = vitesseNormale;
                GetComponent<SpriteRenderer>().flipX=false;
                
            }

            else 
            {

                vitesseY = GetComponent<Rigidbody2D>().velocity.x; //vitesse actuelle
                vitesseX = 0;  //pour empêcher que ça continue d'avancer si aucune touches
                
            }


        //Applique vitesse X et Y
        GetComponent<Rigidbody2D>().velocity=new Vector2(vitesseX,vitesseY);

        //Animation des sprites
           if (vitesseX > 0.9f || vitesseX < -0.9f)
           {
 
                GetComponent<Animator>().SetBool("marche",true); //animation de course activé
 
           }

           else 
           {

                GetComponent<Animator>().SetBool("marche",false); //animation de course non activé

           }
    
            }
        }//fin de partie termine
    }// void update

    /****************************************************
    Détection des collisions
    *****************************************************/


    void OnCollisionEnter2D(Collision2D infosCollision)

        {   
            
            if(infosCollision.gameObject.tag == "dollarJaune")
            {

                Destroy(infosCollision.gameObject); // détruit les dollars
                compteur+= 10; //l'argent augmente de 10 dollars si touche le coin jaune.
                compteurArgent.text=""+ compteur;
            }

            if(infosCollision.gameObject.tag == "dollarOrange")
            {

                Destroy(infosCollision.gameObject); // détruit les dollars
                compteur+= 20; //l'argent augmente de 20 dollars si touche le coin orange.
                compteurArgent.text=""+ compteur;
            }

            if(infosCollision.gameObject.tag == "dollarVert")
            {

                Destroy(infosCollision.gameObject); // détruit les dollars
                compteur+= 30; //l'argent augmente de 30 dollars si touche le coin vert.
                compteurArgent.text=""+ compteur;
            }

        }

    void OnTriggerEnter2D(Collider2D col)
        {
            if(col.gameObject.tag == "Ennemi")
            {
                Destroy(col.gameObject);

                marchand.frozen = true;
                if (marchand.frozen == true)
                {
                    Destroy(col.gameObject);
                }
            }

            if(col.gameObject.tag == "FinGagne")
            {
                SceneManager.LoadScene("SceneFinGagne");
            }
        }

}
