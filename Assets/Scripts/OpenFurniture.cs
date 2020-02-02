using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFurniture : MonoBehaviour
{
    [SerializeField] GameObject openedItem = null;


    private void OnMouseOver() {
        Debug.Log("Mouse is over");
        if (Input.GetMouseButtonUp(0)) {
            Debug.Log("Mouse is up");
            openedItem.SetActive(true);
            gameObject.SetActive(false);
        }
    }



}
