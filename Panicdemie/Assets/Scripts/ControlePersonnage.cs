using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marche : MonoBehaviour
{

    public float vitesseX;
    public float vitesseY;
    public GameObject pieceOr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
            {
                vitesseX = 1;
            }
            else if (Input.GetKey("a"))
            {
                vitesseX = -1;
            }
            else
            {
                vitesseX = GetComponent<Rigidbody2D>().velocity.x;
            }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "PieceOr")
        {
            TextePointage.compteur += 5;

            //GetComponent<AudioSource>().PlayOneShot(sonOr);

            collision.gameObject.SetActive(false);

        }
    }

}