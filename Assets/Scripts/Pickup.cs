using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour {
    
    float throwForce = 600;
    Vector3 objPos;
    float distance;
    public bool canHold = true;
    public GameObject item;
    public GameObject tempParent;
    public GameObject distanceTextObject;
    public GameObject distanceTextPanel;
    public GameObject victoryPanel;
    public Text distanceText;
    //public bool isHolding = false;
    public KeyCode keyCode;

    public Animator animator;

    public Transform guide;


    void Start() {

        //distanceText = distanceTextObject.gameObject.GetComponent<Text>();
        //distanceText = animator.GetComponent<Text>();
        distanceText = GameObject.Find("FinalDistanceText").GetComponent<Text>();
        distanceTextPanel = GameObject.Find("CanvasDistanceText");
        distanceTextPanel.gameObject.SetActive(false);
        //FloatingTextController.Initialize();

    }

    // Update is called once per frame
    void Update() {
        
        //distanceText = GameObject.Find("FinalDistanceText").GetComponent<Text>();

        distance = Mathf.RoundToInt(Vector3.Distance(item.transform.position, tempParent.transform.position));


        //distanceText = distanceTextObject.gameObject.GetComponent<Text>();
        distanceText.text = " " + distance + "m";

        //if(distance >= 3f) {

            //isHolding = false;

        //}

        //if(Input.GetKey(keyCode)) {

            //if(distance <= 15f) {

                //isHolding = true;
                //item.GetComponent<Rigidbody>().useGravity = false;
                //item.GetComponent<Rigidbody>().detectCollisions = true;

            //}

        //}

        //Check if is holding
        //if(isHolding == true) {

            //Debug.Log("Pegou o torete!");
            //item.GetComponent<Rigidbody>().velocity = Vector3.zero;
            //item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            //item.transform.SetParent(tempParent.transform);

            if(Input.GetMouseButton(1)) {

                Debug.Log("Arremessou a bosta!");
                //throw
                item.GetComponent<Rigidbody>().AddForce(tempParent.transform.forward * throwForce);
                //isHolding = false;
                item.GetComponent<Rigidbody>().useGravity = true;
                item.GetComponent<Rigidbody>().isKinematic = false;
                item.transform.parent = null;
                distanceTextPanel.gameObject.SetActive(true);
                //distanceText.text = " " + distance;
                //item.transform.position = guide.transform.position;
                //FloatingTextController.CreateFloatingText(distance.ToString(), this.gameObject.transform);
                //distanceTextObject.gameObject.transform.position = this.gameObject.transform.position;

            }

        //} else {

            //objPos = item.transform.position;
            //item.transform.SetParent(null);
            //item.GetComponent<Rigidbody>().useGravity = true;
            //item.transform.position = objPos;

        //}

    }

    void OnMouseDown() {    

        //if(distance <= 2f) {

            //isHolding = true;
            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().isKinematic = true;
            item.transform.position = guide.transform.position;
            item.transform.rotation = guide.transform.rotation;
            item.transform.parent = tempParent.transform;
            distanceTextPanel.gameObject.SetActive(false);

        //}

    }

    void OnMouseUp() {
        
        item.GetComponent<Rigidbody>().useGravity = false;
        item.GetComponent<Rigidbody>().isKinematic = true;
        //item.transform.parent = null;
        item.transform.position = guide.transform.position;
        item.transform.rotation = guide.transform.rotation;
        item.transform.parent = tempParent.transform;
        distanceTextPanel.gameObject.SetActive(false);

    }

    void OnCollisionEnter(Collision other) {

        //if(other.gameObject.tag == "Player") {

            //if(Input.GetKey(keyCode)) {

                //isHolding = true;
                //item.GetComponent<Rigidbody>().useGravity = false;
                //item.GetComponent<Rigidbody>().detectCollisions = true;

            //}

        //}

        if(other.gameObject.tag == "Floor") {

            victoryPanel.gameObject.SetActive(true);

        }

    }

    public void SetText(string text) {

        //distanceText.text = text; 
        //animator.GetComponent<Text>().text = text;

    }


}
