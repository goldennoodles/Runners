using UnityEngine;
using System.Collections;

public class buttonPress2 : MonoBehaviour {

	// Use this for initialization
	public void OnMouseDown () {

        GameObject items = GameObject.Find("Main Camera");
        Building itemsspec = items.GetComponent<Building>();
        itemsspec.i = 1;
		
	}
}
