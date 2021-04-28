using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_s : MonoBehaviour
{

    public float moveSpeed = 5;
    public GameObject stone_prefab;
    public GameObject wood_prefab;

    public Rigidbody rig;
    private Touch touch;
    private GameObject current = null;

    public bool stone = false;
    public bool wood = false;


    private void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            Ray touchRay = Camera.main.ScreenPointToRay(touch.position);

            float midPoint = (transform.position - Camera.main.transform.position).magnitude;

            transform.LookAt(touchRay.origin + touchRay.direction * midPoint);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

            rig.velocity = transform.forward * moveSpeed;
        }
        if (Input.GetMouseButton(0))
        {

            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            float midPoint = (transform.position - Camera.main.transform.position).magnitude;

            transform.LookAt(mouseRay.origin + mouseRay.direction * midPoint);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
            rig.velocity = transform.forward * moveSpeed;
            this.rig.inertiaTensorRotation = Quaternion.identity;

        }
    }

    private void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.gameObject.tag);
        if (col.gameObject.tag == "Tower" && stone == true)
        {            
            stone = false;
            Destroy(current);
            col.GetComponent<Tower_s>().Reload();
        }

        if (col.gameObject.tag == "Door" && wood ==  true)
        {            
            wood = false;
            Destroy(current);
            col.GetComponent<Door_s>().Repair();
        }

        if (col.gameObject.tag == "Rock" && stone == false)
        {         
            stone = true;
            wood = false;
            Destroy(current);
            current = Instantiate(stone_prefab, this.transform);

        }

        if (col.gameObject.tag == "Tree" && wood == false)
        {
            stone = false;
            wood = true;
            Destroy(current);
            current = Instantiate(wood_prefab, this.transform);

        }

    }





    void Update()
    {
       


    }
}
