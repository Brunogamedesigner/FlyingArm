using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickObjects : MonoBehaviour {

    RaycastHit hit;
    GameObject pickedUpObject;

    public Pickup pickup;

    void Start() {
        
        pickup = pickup.GetComponent<Pickup>();

    }

    // Update is called once per frame
    void Update() {

        if(Input.GetKeyDown(KeyCode.Q)) {

            if(Physics.Raycast(transform.position, transform.forward, 100)) {

                if(hit.collider.gameObject.tag == "Torete") {

                    Debug.Log("pegou o torete!");
                    pickedUpObject = hit.collider.gameObject;
                    hit.collider.gameObject.transform.parent = transform;
                    hit.collider.gameObject.transform.position = transform.position - transform.forward;
                    //pickup.isHolding = true;

                }

            }

        } else {

            pickedUpObject.transform.parent = null;
            pickedUpObject = null;

        }
        
    }
}
