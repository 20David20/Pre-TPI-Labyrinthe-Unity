using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public GameObject wall;
    private bool moving;

    private float startPosX;
    private float startPosY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            Vector3 mousPos;
            mousPos = Input.mousePosition;
            mousPos = Camera.main.ScreenToWorldPoint(mousPos);

            this.gameObject.transform.localPosition = new Vector3(mousPos.x - startPosX, mousPos.y - startPosY, this.gameObject.transform.localPosition.z);
        }
    }

    private void OnMouseDown()
    {
               
        if (Input.GetMouseButtonDown(0))
        {
            if(this.gameObject.transform.position.x == -3.03 && this.gameObject.transform.position.y == -3.85)
            {
                GameObject myGameObject = Instantiate(this.gameObject) as GameObject;
            }
            //GameObject Duplicate = Instantiate(wall);

            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            moving = true;
        }
    }

    private void OnMouseUp()
    {
        moving = false;
    }
}
