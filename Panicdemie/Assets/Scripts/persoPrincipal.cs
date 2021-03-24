using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persoPrincipal : MonoBehaviour
{

    /* public bool MarchePerso;
    public GameObject[] Perso; */

    public float vitesseX; // déplacement dans l'axe horizontale
    public float vitesseY; // déplacement dans l'axe verticale
    public float vitesseSaut=10;
    public float vitesseNormale=5;

    private bool partieTermnine= false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (partieTermnine == false)//si la partie n'est pas perdu
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

            else {
                vitesseY = GetComponent<Rigidbody2D>().velocity.x; //vitesse actuelle
                vitesseX = 0;  //pour empêcher que ça continue d'avancer si aucune touches
                
            }


        //Applique vitesse X et Y
        GetComponent<Rigidbody2D>().velocity=new Vector2(vitesseX,vitesseY);

        //Animation des sprites
           if(vitesseX > 0.9f || vitesseX < -0.9f)
           {
 
        GetComponent<Animator>().SetBool("marche",true); //animation de course activé
 
           }
           else
           {
         GetComponent<Animator>().SetBool("marche",false); //animation de course non activé
           }
    

        }//fin de partie termine
    }// void update

   

}
