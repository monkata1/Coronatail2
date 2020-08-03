using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BottleScript : MonoBehaviour
{
    GameObject cam;
    public GameObject bottle;
    bool isclicked = false;

    private void Start()
    {
       // cam.transform.position = this.transform.position;
    }

    

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (isclicked == false) return;
       //this.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z+2);
    }

    public void OnMouseDown()
    {
        //Debug.Log("asdasdas");
        //isclicked = true;
        //cam = GameObject.FindGameObjectWithTag("MainCamera");
    }
}
