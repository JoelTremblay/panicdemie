using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
 * Contrôle barre de vie
 * Par : Feng Jiayi
 */
public class HealthBar : MonoBehaviour
{

    public Slider healthBar;
    public int life;
    private int max;

    // Start is called before the first frame update
    void Start()
    {
        max = 100;
        life = 100;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = (float)life / max;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "ennemi")
        {
            life -= 20;
        }
    }
}
