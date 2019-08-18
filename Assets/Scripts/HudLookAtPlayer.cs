using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudLookAtPlayer : MonoBehaviour {

    public GameObject player;

    // Start is called before the first frame update
    void Start() {
        
        player = GameObject.Find("FirstPersonCharacter");

    }

    // Update is called once per frame
    void Update() {
        
        Vector3 lookVector = player.gameObject.transform.position - transform.position;
        lookVector.y = transform.position.y;
        Quaternion rot = Quaternion.LookRotation(lookVector);
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, 1);

    }
}
