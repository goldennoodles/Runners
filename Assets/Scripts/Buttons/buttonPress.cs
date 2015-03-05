using UnityEngine;
using System.Collections;

public class buttonPress : MonoBehaviour {

	// Use this for initialization
	public void OnMouseDown () {

        GameObject items = GameObject.Find("Main Camera");
        characterMovement itemsspec = items.GetComponent<characterMovement>();
        itemsspec.i = 1;
		
	}
}
