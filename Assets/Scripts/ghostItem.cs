using UnityEngine;
using System.Collections;

public class ghostItem : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

    void Update()
    {
        ghost();
        rotate();
    }

	void ghost () {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray,out hit))
        {
            transform.position = new Vector3(hit.point.x, hit.point.y, hit.point.z);
        }
	
	}

    void rotate()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.Rotate(0, 90, 0);
        }

        
    }
}
