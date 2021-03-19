using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePersonnage : MonoBehaviour
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
                vitesseX = 5;
            }
            else if (Input.GetKey("a"))
            {
                vitesseX = -5;
            }
            else
            {
                vitesseX = GetComponent<Rigidbody2D>().velocity.x;
            }

            if (Input.GetKeyDown("w"))
            {
                vitesseY = 6.5f;
            }
            else
            {
                vitesseY = GetComponent<Rigidbody2D>().velocity.y;
            }

            GetComponent<Rigidbody2D>().velocity = new Vector2(vitesseX, vitesseY);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "pieceOr")
        {
            TextePointage.compteur += 5;

            //GetComponent<AudioSource>().PlayOneShot(sonOr);

            collision.gameObject.SetActive(false);

        }
    }

}