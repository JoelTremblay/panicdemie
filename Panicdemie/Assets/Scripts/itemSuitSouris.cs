using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSuitSouris : MonoBehaviour
{
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Input.mousePosition;
    }
}
