using UnityEngine;
using System.Collections;

public class characterMovement : MonoBehaviour
{

    public int speed;

    private Vector3 endPoint;

    public GameObject[] items;

    public Transform walls;

    public Transform campfire;

    private int maxDistance = 10;

    public ghostItem GhostItem;


    void Start(){
        GhostItem = GetComponent<ghostItem>();
        

    }

    void Update()
    {

        //------------//
        //CameraZoom();
        Switchs();
        CursorActions();
        ObjRotation();
        //CameraMouseLook();
        //-------------//

         if (Input.GetMouseButtonDown(0))
         {
              Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
              // Storage point for the Ray
              RaycastHit hit;

                if (Physics.Raycast(ray, out hit, maxDistance))
                 {
                     // Assigning the point its variable
                     endPoint = hit.point;


                     GameObject clone;

                     // Clone the objects and spawn them in the game 'world'
                     clone = Instantiate(items[i], endPoint, items[i].transform.rotation) as GameObject;
                 }
          }
    }
    
    void CameraZoom()
    {
        transform.Translate(Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * speed);
        print("CameraZoom has loaded");

    }

    public int i;

    void Switchs()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            i = 0;
            print("Selecting Camp fire");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            i = 1;
            GhostItem.enabled = true;
            print("Selecting Wooden Spiked Walls");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            i = 2;
            print("Selecting Barrel");
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            i = 3;
        }
    }


    void CameraMouseLook()
    {
        transform.position = new Vector3(0, 0, 0) * Time.deltaTime;
        print("CameraMouseLook has loaded");
        
        //Dead, pointless, non-functioning code.

    }

    void CursorActions()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }

        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.None;

        }

    }

    void ObjRotation()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            walls.transform.Rotate(0, 90, 0);
            campfire.transform.Rotate(0, 90, 0);
            print("rotating item: 90");
        }
    }

}


