using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
/* Ouverture de l'inventaire en cliquant sur l'icone et animation de hover.
 * Par : Joël Tremblay
*/
public class iconeInventaire : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public UIInventaire inventaireUI;
    Vector3 cachedScale;

    void Start() {
 
         cachedScale = transform.localScale;
     }

    public void OnPointerClick(PointerEventData eventData)
    {
        inventaireUI.gameObject.SetActive(!inventaireUI.gameObject.activeSelf);
    }

    public void OnPointerEnter(PointerEventData eventData) {
 
         transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
     }
 
     public void OnPointerExit(PointerEventData eventData) {
 
         transform.localScale = cachedScale;
     }
}
