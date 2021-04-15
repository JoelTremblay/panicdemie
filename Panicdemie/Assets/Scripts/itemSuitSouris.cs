using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Méthode pour que l'infobulle et les objets sélesctionnés suivent la souris.
 * Par : Joël Tremblay
*/
public class itemSuitSouris : MonoBehaviour
{
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Input.mousePosition;
    }
}
