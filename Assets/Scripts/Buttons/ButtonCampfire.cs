using UnityEngine;
using System.Collections;

public class ButtonCampfire : MonoBehaviour
{

    public void OnMouseDown()
    {

        GameObject items = GameObject.Find("Main Camera");
        characterMovement itemsspec = items.GetComponent<characterMovement>();
        itemsspec.i = 0;

    }
}